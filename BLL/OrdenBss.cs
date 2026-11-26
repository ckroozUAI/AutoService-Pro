using DAL;
using Entities;
using System;
using System.Linq;
using System.Transactions;

namespace BLL
{
    public class OrdenBss
    {
        private readonly OrdenDao _ordenDao = new OrdenDao();

        // RN1: Kilometraje >= al último histórico del vehículo
        public void ValidarKilometrajeRN1(int idVehiculo, int kilometrajeDeclarado)
        {
            if (kilometrajeDeclarado < 0)
                throw new Exception("RN1: El kilometraje no puede ser negativo.");

            int ultimoKm = _ordenDao.ObtenerUltimoKilometraje(idVehiculo);

            if (kilometrajeDeclarado < ultimoKm)
                throw new Exception($"RN1: El kilometraje ingresado ({kilometrajeDeclarado} km) no puede ser menor al último histórico ({ultimoKm} km).");
        }

        // RN2: Cantidad requerida <= STOCK_FISICO en depósito
        public void ValidarStockRN2(int idRepuesto, int cantidadRequerida, string nombreRepuesto = "")
        {
            if (cantidadRequerida <= 0)
                throw new Exception("RN2: La cantidad requerida debe ser mayor a cero.");

            int stockDisponible = _ordenDao.ObtenerStockActual(idRepuesto);

            if (cantidadRequerida > stockDisponible)
                throw new Exception($"RN2: Stock insuficiente para '{nombreRepuesto}' (ID {idRepuesto}). Requerido: {cantidadRequerida}, Disponible: {stockDisponible}.");
        }

        // Cierre y Liquidación de Orden con TransactionScope (RN1 + RN2 + RN3 + Persistencia)
        public void CerrarOrden(OrdenTrabajoEntity orden)
        {
            try
            {
                // RN3
                if (orden.CostoTotal <= 0)
                    throw new Exception("RN3: No se permite finalizar: el balance de mano de obra y repuestos debe ser mayor a cero.");

                if (orden.IdTecnico == null || orden.IdTecnico == 0)
                    throw new Exception("RN3: No se permite finalizar: la orden carece de técnico asignado.");

                // RN1
                if (orden.IdVehiculo > 0)
                    ValidarKilometrajeRN1(orden.IdVehiculo, orden.KilometrajeIngreso);

                // RN2
                foreach (var grupo in orden.Detalles.GroupBy(d => d.IdRepuesto))
                {
                    int totalRequerido = grupo.Sum(x => x.Cantidad);
                    string desc = grupo.First().DescripcionRepuesto;
                    ValidarStockRN2(grupo.Key, totalRequerido, desc);
                }

                // Cálculo de totales
                if (orden.Detalles.Any() || orden.ManoObra > 0)
                {
                    decimal subtotal = orden.Detalles.Sum(d => d.Cantidad * d.PrecioUnitario) + orden.ManoObra;
                    orden.Impuestos = Math.Round(subtotal * 0.21m, 2);
                    orden.CostoTotal = subtotal + orden.Impuestos;
                }

                orden.Estado = "Finalizada";
                orden.FechaCierre = DateTime.Now;

                // Transacción atómica en SQL Server
                using (var scope = new TransactionScope())
                {
                    orden.Id = _ordenDao.InsertarOrden(orden);

                    foreach (var detalle in orden.Detalles)
                    {
                        detalle.IdOrden = orden.Id;
                        _ordenDao.InsertarDetalle(detalle);
                        _ordenDao.DescontarStock(detalle.IdRepuesto, detalle.Cantidad);
                    }

                    if (orden.IdVehiculo > 0)
                        _ordenDao.ActualizarKilometrajeVehiculo(orden.IdVehiculo, orden.KilometrajeIngreso);

                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // RN4
        public void AnularOrden(OrdenTrabajoEntity orden)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (orden.Estado == "Finalizada" || orden.Estado == "Cobrada")
                        throw new Exception("RN4: Una orden 'Finalizada' no puede ser eliminada directamente. Requiere nota de crédito.");

                    orden.Estado = "Anulada";

                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}