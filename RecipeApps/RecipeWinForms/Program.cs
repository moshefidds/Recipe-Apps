using CPUFramework;
using RecipeSystem;
namespace RecipeWinForms
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
            ApplicationConfiguration.Initialize();
            DBManager.SetConnectionString("Server=tcp:mfiddle-cpu.database.windows.net,1433;Initial Catalog=RecipeDB;Persist Security Info=False;User ID=moshefiddle1234@gmail.com@mfiddle-cpu;Password=MoeFidds6074!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            Application.Run(new frmSearch());
        }
    }
}