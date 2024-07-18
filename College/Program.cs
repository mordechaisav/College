using College.DAL.views;
using College.DAL.Repositories;
using College.DAL;
using EmployeeCRM.Services;

namespace College
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var isNavigating = false;
            NavigationService.ShowForm("form1", ref isNavigating);
            Application.Run();
        }
    }
}