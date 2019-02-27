# Presentation
A NuGet package for detect Operating System and execute system commands

Write on.NET Standard 2.0

[Visite the project on nuget.org](https://www.nuget.org/packages/DetectOsAndExecuteCommands/)


# How to install

Package Manager:
```
Install-Package DetectOsAndExecuteCommands -Version 1.0.0
```

.NET CLI:
```
dotnet add package DetectOsAndExecuteCommands --version 1.0.0
```

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
