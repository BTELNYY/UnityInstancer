using Newtonsoft.Json;

namespace UnityInstancer
{
    public static class Program
    {
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            DebugConsole.StartConsole();
#endif
            InstanceManager.LoadInstances();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}