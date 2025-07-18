using Newtonsoft.Json;
using System.Diagnostics;

namespace UnityInstancer
{
    public class InstanceManager
    {
        public static event Action? InstancesChanged;

        public const string DIRECTORY = "Instances";

        public static string GamePath = Directory.GetCurrentDirectory();

        public static string TargetDir
        {
            get
            {
                return Path.Combine(GamePath, DIRECTORY);
            }
        }

        public static List<Instance> Instances = new();

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
                        //Directory.Delete(path, true);
                        continue;
                    }
                }
            }
        }


        public static void Delete(int index)
        {
            Instance instance = Instances[index];
            try
            {
                Directory.Delete(instance.FolderPath, true);
            }
            catch (Exception)
            {

            }
            InstancesChanged?.Invoke();
        }

        public static void LaunchInstance(int index)
        {
            Instance instance = Instances[index];
            string exePath = Path.Combine(instance.FolderPath, $"{instance.Name}.exe");
            Process.Start(exePath);
        }

        public static bool LaunchInstance(string name)
        {
            int instance = Instances.FindIndex(x => x.Name == name);
            if (instance == -1)
            {
                return false;
            }
            LaunchInstance(instance);
            return true;
        }

        public static int FindInstance(string name)
        {
            return Instances.FindIndex(x => x.Name == name);
        }

        public static void EditInstance(int index, Instance instance)
        {
            File.Delete(Path.Join(instance.FolderPath, "Instance.json"));
            string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(Path.Join(instance.FolderPath, "Instance.json"), json);
            Instances[index] = instance;
            InstancesChanged?.Invoke();
        }

        public static void CreateInstance(Instance instance)
        {
            InstancesChanged?.Invoke();
            string targetPath = Path.Combine(TargetDir, instance.Name);
            Directory.CreateDirectory(targetPath);
            string gameExeName = string.Empty;
            foreach (string item in Directory.GetFiles(InstanceManager.GamePath))
            {
                string filename = Path.GetFileName(item);
                if (filename == AppDomain.CurrentDomain.FriendlyName)
                {
                    continue;
                }
                if (filename.Contains("UnityInstancer"))
                {
                    continue;
                }
                if (Directory.Exists(Path.Combine(GamePath, Path.GetFileNameWithoutExtension(item) + "_Data")))
                {
                    gameExeName = Path.GetFileNameWithoutExtension(item);
                    File.Copy(item, Path.Combine(targetPath, filename.Replace(Path.GetFileNameWithoutExtension(item), instance.Name)));
                    continue;
                }
                File.Copy(item, Path.Combine(targetPath, filename));
            }

            foreach (string dir in Directory.GetDirectories(GamePath))
            {
                string dirName = dir.Split(Path.DirectorySeparatorChar).Last();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                if (dirName.Contains("_Data"))
                {
#pragma warning disable CS8604 // Possible null reference argument.
                    JunctionPoint.Create(dir, Path.Combine(targetPath, dirName.Replace(dirName, instance.Name + "_Data")), true);
                    continue;
#pragma warning restore CS8604 // Possible null reference argument.
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.
                JunctionPoint.Create(dir, Path.Combine(targetPath, dirName), true);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            File.Delete(Path.Join(targetPath, "Instance.json"));
            string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(Path.Join(targetPath, "Instance.json"), json);
            instance.FolderPath = targetPath;
            Instances.Add(instance);
            InstancesChanged?.Invoke();
        }
    }
}
