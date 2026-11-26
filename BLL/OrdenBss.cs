using DAL;
using Entities;
using System;
using System.Transactions;

namespace BLL
{
    public class OrdenBss
    {

        public void CerrarOrden(OrdenTrabajoEntity orden)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (orden.CostoTotal <= 0)
                        throw new Exception("No se permite finalizar: el balance de mano de obra y repuestos debe ser mayor a cero.");

                    if (orden.IdTecnico == 0)
                        throw new Exception("No se permite finalizar: la orden carece de técnico asignado.");

                    orden.Estado = "Finalizada";

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AnularOrden(OrdenTrabajoEntity orden)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (orden.Estado == "Finalizada" || orden.Estado == "Cobrada")
                        throw new Exception("Una orden 'Finalizada' no puede ser eliminada directamente. Requiere nota de crédito.");

                    orden.Estado = "Anulada";

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}