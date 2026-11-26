using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class VehiculoBss
    {
        private VehiculoDao dao = new VehiculoDao();

        public List<VehiculoEntity> getByCliente(int idCliente)
        {
            try
            {
                return dao.getByCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void save(VehiculoEntity entity)
        {
            try
            {
                entity.Patente = (entity.Patente ?? "").Trim().ToUpper();
                entity.Marca = (entity.Marca ?? "").Trim();
                entity.Modelo = (entity.Modelo ?? "").Trim();

                if (entity.IdCliente <= 0) throw new Exception("Debe seleccionar un cliente.");
                if (entity.Patente == "") throw new Exception("La patente es obligatoria.");
                if (entity.Marca == "") throw new Exception("La marca es obligatoria.");
                if (entity.Modelo == "") throw new Exception("El modelo es obligatorio.");
                if (entity.Anio < 1950 || entity.Anio > DateTime.Now.Year + 1)
                    throw new Exception("El año no es válido.");

                using (var scope = new TransactionScope())
                {
                    var existente = dao.getByPatente(entity.Patente);
                    if (existente != null && existente.Id != entity.Id)
                        throw new Exception("Ya existe un vehículo con esa patente.");

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

        public void delete(int id)
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
