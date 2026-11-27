using DAL;
using Entities;
using System;
using System.Linq;
using System.Transactions;
using UI;

namespace BLL
{
    public class OrdenBss
    {
        private readonly OrdenDao _ordenDao = new OrdenDao();
        private readonly VehiculoBss _vehiculoBss= new VehiculoBss();

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

         public void CerrarOrden(OrdenServicioEntity orden)
        {
            try
            {
                if (orden.Estado == EstadosOrdenes.Anulada)
                    throw new Exception("Una orden 'Anulada' no puede ser Finalizada.");

                orden.Estado = "Finalizada";
                orden.FechaCierre = DateTime.Now;

                 using (var scope = new TransactionScope())
                {
                    _ordenDao.finalizarOrden(orden.IdOrden); 
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // RN4
        public void AnularOrden(OrdenServicioEntity orden)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (orden.Estado == EstadosOrdenes.Finalizada)
                        throw new Exception("RN4: Una orden 'Finalizada' no puede ser anulada.");

                    if (orden.Estado == EstadosOrdenes.Anulada)
                        throw new Exception("RN4: Una orden 'Anulada' no puede ser anulada.");

                    orden.Estado = "Anulada";
                    _ordenDao.AnularOrden(orden.IdOrden);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // RN2 + TransactionScope: Valida stock, descuenta en REPUESTO, inserta orden y revierte todo si falla
        public void CrearOrden(OrdenServicioEntity orden, int idRepuesto, int cantidadRepuesto)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var vehiculo = _vehiculoBss.getById(orden.IdVehiculo);
                    if (vehiculo == null)
                        throw new Exception($"No se encontro un vehiculo con el ID : {orden.IdVehiculo}");

                    if (vehiculo.Kilometraje > orden.Kilometraje)
                        throw new Exception($"El kilometraje de ingreso {orden.Kilometraje}, no puede ser menor al ultimo kilometraje cargado del vehiculo {vehiculo.Kilometraje}");

                    orden.FechaIngreso = DateTime.Now;
                    orden.Estado = EstadosOrdenes.Presupuestada;

                    // 1. Inserta cabecera en ORDEN_SERVICIO y obtiene IdOrden
                    _ordenDao.InsertarOrden(orden);

                    // 2. Si hay repuestos imputados, valida RN2 y descuenta stock dentro de la transacción
                    if (cantidadRepuesto > 0)
                    {
                        var repuestoBss = new RepuestoBss();
                        var repuesto = repuestoBss.getById(idRepuesto);
                        if (repuesto == null)
                            throw new Exception($"No se encontro un repuesto con el ID : {idRepuesto}");

                        // Valida contra el stock real en BD antes de descontar
                        ValidarStockRN2(idRepuesto, cantidadRepuesto, repuesto.Descripcion);

                        repuesto.StockFisico -= cantidadRepuesto;
                        repuestoBss.DescontarRepuesto(repuesto);
                    }

                    // 3. Actualiza kilometraje del vehículo
                    vehiculo.Kilometraje = orden.Kilometraje;
                    _vehiculoBss.actualizarKilometraje(vehiculo);

                    // Solo si todo pasó sin excepciones se confirma (Commit)
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                // Al salir del using sin scope.Complete(), TransactionScope hace Rollback automático
                throw;
            }
        }

        public List<OrdenServicioEntity> getAll()
        {
            try
            {
                return _ordenDao.getAll();                    
                 
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}