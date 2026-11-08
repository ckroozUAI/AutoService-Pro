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
             ApplicationConfiguration.Initialize();

             LoginForm loginForm = new LoginForm();

             
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                 Application.Run(new Form1());
            }
            else
            {
                // Si cierra la ventana sin loguearse, la aplicación termina limpiamente
                Application.Exit();
            }
        }
    }
}