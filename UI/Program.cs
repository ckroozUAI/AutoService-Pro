namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();


            Application.SetHighDpiMode(HighDpiMode.DpiUnaware); // Configuración para que la aplicación no se escale automáticamente en pantallas de alta resolución
            Application.EnableVisualStyles(); // Habilita los estilos visuales para la aplicación
            Application.SetCompatibleTextRenderingDefault(false); // Configura el renderizado de texto para que sea compatible con versiones anteriores de Windows Forms


            LoginForm loginForm = new LoginForm();

             
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                 Application.Run(new MenuForm());
            }
            else
            {
                // Si cierra la ventana sin loguearse, la aplicación termina limpiamente
                Application.Exit();
            }
        }
    }
}