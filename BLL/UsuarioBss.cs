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
    public class UsuarioBss
    {
        private UsuarioDao dao = new UsuarioDao();

        public void login(UsuarioEntity entity)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var model =dao.getUser(entity.Usuario);
                    bool esValido = BCrypt.Net.BCrypt.Verify(entity.Password, model.Password);
                    if (!esValido) throw new Exception("No se pudo realizar el inicion de sesón, verificar credenciales.");
                    scope.Complete();
                }                   

            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public void create(UsuarioEntity entity)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    entity.Password = BCrypt.Net.BCrypt.HashPassword(entity.Password);
                    dao.create(entity);
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
