using Newtonsoft.Json;

namespace UnityInstancer
{
    public static class Program
    {
        public const string DIRECTORY = "/Instances/";

        public static string GamePath = Directory.GetCurrentDirectory();

        public static string TargetDir
        {
            get
            {
                return Path.Combine(GamePath, DIRECTORY);
            }
        }

        public static List<Instance> Instances = new List<Instance>();

        public static void LoadInstances()
        {
            Instances.Clear();
            if (!Directory.Exists(TargetDir))
            {
                Directory.CreateDirectory(TargetDir);
            }
            else
            {
                string[] dirs = Directory.GetDirectories(TargetDir);
                Console.WriteLine("Discovering Instances:");
                Console.WriteLine(string.Join("\n", dirs));
                foreach (string dir in dirs)
                {
                    string path = Path.Combine(dir, "Instance.json");
                    if (File.Exists(path))
                    {
                        string cfgFile = File.ReadAllText(path);
                        Instance? instanceCfg = JsonConvert.DeserializeObject<Instance>(cfgFile);
                        if (instanceCfg == null)
                        {
                            DebugConsole.WriteLineColor("Unable to deserialize an instance config. Path: " + path, ConsoleColor.Red);
                            continue;
                        }
                        instanceCfg.FolderPath = dir;
                        Instances.Add(instanceCfg);
                    }
                    else
                    {
                        DebugConsole.WriteLineColor("Unable to find an instance config. Dir: " + dir, ConsoleColor.Red);
                        continue;
                    }
                }
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            DebugConsole.StartConsole();
#endif
            LoadInstances();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}