namespace pryVargasSP1PorResolver
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Aplication.Run determina que formulario se inicia primero
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}