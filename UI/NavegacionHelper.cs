using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public static class NavegacionHelper
    { 
        public static void AbrirYEsperar(Form origen, Form destino)
        {
            if (origen == null || destino == null) return;

            origen.Hide();
            try
            {
                destino.ShowDialog(origen);
            }
            finally
            {
                destino.Dispose();
                if (!origen.IsDisposed)
                {
                    origen.Show();
                    origen.Activate();
                }
            }
        }
 
        public static void VolverAMenu(Form hijoActual, Form menu)
        {
            if (hijoActual == null) return;

            if (menu != null && !menu.IsDisposed)
            {
                menu.Show();
                menu.Activate();
            }

            hijoActual.Close();
        }
    }
}
