using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace BLL
{
    public class RepuestoBss
    {
        private RepuestoDao dao = new RepuestoDao();

        public List<RepuestoEntity> getAll()
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

        public void create(RepuestoEntity entity)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (string.IsNullOrWhiteSpace(entity.Codigo))
                        throw new Exception("El código del repuesto es obligatorio.");

                    if (string.IsNullOrWhiteSpace(entity.Descripcion))
                        throw new Exception("La descripción del repuesto es obligatoria.");

                    if (entity.Precio <= 0)
                        throw new Exception("El precio debe ser mayor a cero.");

                    if (entity.StockFisico < 0)
                        throw new Exception("El stock físico no puede ser negativo.");

                    var existente = dao.getByCodigo(entity.Codigo);
                    if (existente != null)
                        throw new Exception("Ya existe un repuesto registrado con ese código.");

                    dao.create(entity);
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