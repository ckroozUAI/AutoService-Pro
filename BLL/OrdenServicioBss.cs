using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace BLL
{
    public class OrdenServicioBss
    {
        private OrdenDao dao = new OrdenDao();

        public List<OrdenServicioEntity> getAll()
        {
            try
            {
                return dao.getAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // RN3: Cierre de Órdenes Pendientes
        public void finalizarOrden(int idOrden)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var orden = dao.getById(idOrden);
                    if (orden == null)
                        throw new Exception("La orden de servicio seleccionada no existe.");

                    if (orden.Estado != null &&
                       (orden.Estado.Equals("Finalizada", StringComparison.OrdinalIgnoreCase) ||
                        orden.Estado.Equals("Finalizada/Cobrada", StringComparison.OrdinalIgnoreCase)))
                    {
                        throw new Exception("La orden ya se encuentra finalizada.");
                    }

                    if (!orden.IdTecnico.HasValue || orden.IdTecnico.Value <= 0)
                    {
                        throw new Exception("RN3: No se permite facturar o marcar como 'Finalizada' una orden de trabajo que carezca de técnico asignado.");
                    }

                    if ((orden.ManoObra + orden.TotalRepuestos) <= 0)
                    {
                        throw new Exception("RN3: No se permite facturar o marcar como 'Finalizada' una orden cuyo balance de mano de obra y repuestos sea igual a cero.");
                    }

                    dao.finalizarOrden(idOrden);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // RN4: Restricción de Anulación
        public void eliminarOrden(int idOrden)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var orden = dao.getById(idOrden);
                    if (orden == null)
                        throw new Exception("La orden de servicio seleccionada no existe.");

                    if (!string.IsNullOrEmpty(orden.Estado) &&
                       (orden.Estado.Equals("Finalizada", StringComparison.OrdinalIgnoreCase) ||
                        orden.Estado.Equals("Cobrada", StringComparison.OrdinalIgnoreCase) ||
                        orden.Estado.Equals("Finalizada/Cobrada", StringComparison.OrdinalIgnoreCase)))
                    {
                        throw new Exception("RN4: Una orden con estado 'Finalizada/Cobrada' no puede ser eliminada del sistema directamente; requiere un flujo específico de nota de crédito o anulación auditada.");
                    }

                    dao.delete(idOrden);
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