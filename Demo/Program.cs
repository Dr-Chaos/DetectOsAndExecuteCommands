using System;
using DetectOsAndExecuteCommands;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execute system command:");
            if (Os.IsWindows())
            {
                Os.SystemCommand("echo You are on Windows");
            }
            else if (Os.IsLinux())
            {
                Os.SystemCommand("echo You are on Linux");
            }

            Os.SystemCommand("git --version");

            Console.ReadKey();
        }
    }
}
