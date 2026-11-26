using DAL;
using Entities;
using System.Collections.Generic;
using System.Transactions;

namespace BLL
{
    public class RepuestoBss
    {
        private RepuestoDao dao = new RepuestoDao();

        public List<RepuestoEntity> ObtenerTodos()
        {
            try
            {
                return dao.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void RegistrarNuevoRepuesto(RepuestoEntity entity)
        {
            try
            {
                entity.Codigo = (entity.Codigo ?? "").Trim();
                entity.Descripcion = (entity.Descripcion ?? "").Trim();

                if (entity.Codigo == "") throw new Exception("El código del repuesto es obligatorio.");
                if (entity.Descripcion == "") throw new Exception("La descripción del repuesto es obligatoria.");
                if (entity.Precio < 0) throw new Exception("El precio no puede ser negativo.");
                if (entity.StockFisico < 0) throw new Exception("El stock físico no puede ser negativo.");

                using (var scope = new TransactionScope())
                {
                    var existente = dao.getByCodigo(entity.Codigo);
                    if (existente != null && existente.Id != entity.Id)
                        throw new Exception("Ya existe un repuesto con ese código.");

                    if (entity.Id == 0) dao.create(entity);
                    else dao.update(entity);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarRepuesto(int id)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    dao.delete(id);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}