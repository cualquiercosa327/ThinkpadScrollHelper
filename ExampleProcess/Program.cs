using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

class Program
{
    static void Main(string[] args)
    {
        if (true)
        {
            var fullpath = Environment.ExpandEnvironmentVariables(@"%windir%\system32\notepad.exe");
            Process.Start(fullpath);
        }
        return;

        while (true)
        {
            Thread.Sleep(1000);
            var p = Cursor.Position;
            Console.WriteLine($"{p.X}, {p.Y}");
        }

        if (false)
        {
            var processes = Process.GetProcessesByName("notepad");
            Console.WriteLine(processes.Length);
        }

        // var p = Process.GetProcessById(0);
        // Console.WriteLine(p.Id);
        /*
        var processes = Process.GetProcesses();
        foreach(var process in processes)
        {
            Console.WriteLine("--------");
            Console.WriteLine(process.ProcessName);
            try
            {
                // Console.WriteLine(process.StartInfo.Arguments);
                Console.WriteLine(process.MainModule.ModuleName);
                Console.WriteLine(process.MainModule.FileName);
            }
            catch (Exception)
            {
            }
        }
        */
        // Process.Start("notepad.exe");
        // Process p = Process.Start("notepad.exe");
        // p.WaitForExit();

        // Process.Start("sakura.exe");

        return;

        string scrollBackgroundPath = @"C:\Program Files (x86)\Lenovo\ThinkPad Compact Keyboard with TrackPoint driver\HScrollFun.exe";
        string scrollBackgroundName = @"HScrollFun";
        // scrollBackgroundPath = @"C:\WINDOWS\system32\notepad.exe";
        // scrollBackgroundName = @"notepad";

        var processesScroll = Process.GetProcessesByName(scrollBackgroundName);
        // Console.WriteLine(processesScroll.Length);
        if (processesScroll.Length < 1)
        {
            Console.WriteLine($"---- Restart {scrollBackgroundName} ----");
            Process.Start(scrollBackgroundPath);
        }
    }
}
