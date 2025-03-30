using System.Runtime.InteropServices;

namespace UnityInstancer
{
    public class DebugConsole
    {
        //dont ask me how this works, I dont know.
        [DllImport("kernel32")]
        static extern int AllocConsole();
        [DllImport("kernel32")]
        static extern int FreeConsole();
        public static bool ConsoleCreated;
        public static void StartConsole()
        {
            AllocConsole();
            ConsoleCreated = true;
        }
        public static void StopConsole()
        {
            ConsoleCreated = false;
            FreeConsole();
        }
        public static void WriteLineColor(string text, ConsoleColor color)
        {
            if (!ConsoleCreated)
            {
                return;
            }
            //these 3 lines are important, So I need to make them a method.
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static string? ReadConsole(string displaypath)
        {
            if (!ConsoleCreated)
            {
                return null;
            }
            Console.Write(displaypath);
            return Console.ReadLine();
        }
    }
}
