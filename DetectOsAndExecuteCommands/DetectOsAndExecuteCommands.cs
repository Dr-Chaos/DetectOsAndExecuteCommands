using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DetectOsAndExecuteCommands
{
    public class Os
    {
        public static bool IsWindows()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

        public static bool IsMacOs()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        }

        public static bool IsLinux()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }

        public static void SystemCommand(string command)
        {
            string fileName;
            string arguments;
            if (IsWindows())
            {
                fileName = "cmd";
                arguments = $"/C {command}";

            }
            else if (IsLinux())
            {
                fileName = "/bin/bash";
                arguments = $"-c \"{command}\"";
            }
            else if (IsMacOs())
            {
                //not tested on MacOS
                return;
            }
            else
            {
                Console.WriteLine("Your OS is not supported");
                return;
            }

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,

                    UseShellExecute = false,
                }
            };
            process.Start();
            process.WaitForExit();
        }
    }
}