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
    public class ClienteBss
    {
        private ClienteDao dao = new ClienteDao();
        private VehiculoDao vehiculoDao = new VehiculoDao();

        public List<ClienteEntity> getAll()
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

        public void save(ClienteEntity entity)
        {
            try
            {
                entity.Nombre = (entity.Nombre ?? "").Trim();
                entity.Apellido = (entity.Apellido ?? "").Trim();
                entity.Dni = (entity.Dni ?? "").Trim();

                if (entity.Nombre == "") throw new Exception("El nombre es obligatorio.");
                if (entity.Apellido == "") throw new Exception("El apellido es obligatorio.");
                if (entity.Dni == "") throw new Exception("El DNI es obligatorio.");
                if (!string.IsNullOrWhiteSpace(entity.Email) && !entity.Email.Contains('@'))
                    throw new Exception("El email no es válido.");

                using (var scope = new TransactionScope())
                {
                    var existente = dao.getByDni(entity.Dni);
                    if (existente != null && existente.Id != entity.Id)
                        throw new Exception("Ya existe un cliente con ese DNI.");

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
                    if (vehiculoDao.hasVehiculos(id))
                        throw new Exception("No se puede eliminar un cliente que tiene vehículos asociados. Elimine primero sus vehículos.");

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
