namespace UnityInstancer
{
    public static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
#if DEBUG
            DebugConsole.StartConsole();
#endif
            InstanceManager.LoadInstances();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!HandleInput(args))
            {
                return;
            }

            MainForm mainForm = new();
            //mainForm.ShowDialog();
            Application.Run(mainForm);
        }

        static bool HandleInput(string[] input)
        {
            if (input.Length == 0)
            {
                return true;
            }
            return HandleInputRecursive([.. input]);
        }

        static bool HandleInputRecursive(List<string> input)
        {
            if (input.Count == 0)
            {
                return false;
            }
            string command = input[0].ToLower();
            input.RemoveAt(0);
            switch (command)
            {
                case "--launch":
                    string target = input[0];
                    input.RemoveAt(0);
                    if (!InstanceManager.LaunchInstance(target))
                    {
                        MessageBox.Show($"No such instance '{target}'.", "Error", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;
                case "--delete":
                    string deletetarget = input[0];
                    input.RemoveAt(0);
                    int index = InstanceManager.FindInstance(deletetarget);
                    if(index == -1)
                    {
                        MessageBox.Show($"No such instance '{deletetarget}'.", "Error", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        InstanceManager.Delete(index);                    
                    }
                    break;
                case "--create":
                    string name = input[0];
                    input.RemoveAt(0);
                    string description = input[0];
                    input.RemoveAt(0);
                    string args = input[0];
                    input.RemoveAt(0);
                    List<string> arguments = args.Split("|").ToList();
                    Instance instance = new Instance()
                    {
                        Name = name,
                        Description = description,
                        Arguments = arguments,
                    };
                    InstanceManager.CreateInstance(instance);
                    break;
                default:
                    MessageBox.Show("Unknown command: " + command, "Error", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
            return HandleInputRecursive(input);
        }
    }
}