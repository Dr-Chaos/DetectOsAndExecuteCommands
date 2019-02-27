# Presentation
An easy to use library for detect Operating System and execute system command. Write un .NET Standard 2.0

# How to install

# How to use
A simple demo how to use it
```
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
```