using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag;
            Process pr = new Process();
            pr.StartInfo.FileName = "WindowsFormsApp1.exe";
            pr.Start();

            WriteLine("按1是调用process.kill");
            WriteLine("按2是调用process.Close");
            WriteLine("按3是调用process.CloseMainWindow");
            WriteLine("按4是调用process.Dispose");
            while (true)
            {
                flag =Console.ReadLine();
                Process[] pProcess;
                pProcess = Process.GetProcesses();
                for (int i = 1; i <= pProcess.Length - 1; i++)
                {
                    if (pProcess[i].ProcessName == "WindowsFormsApp1")   //任务管理器应用程序的名
                    {
                        switch(flag)
                        {
                            case "1":pProcess[i].Kill();Thread.Sleep(20); break;
                            case "2":pProcess[i].Close(); Thread.Sleep(10); break;
                            case "3":pProcess[i].CloseMainWindow(); Thread.Sleep(500); break;
                            case "4":pProcess[i].Dispose(); Thread.Sleep(10); break;
                        }
                    }
                }

                Process[] p;
                p = Process.GetProcesses();
                bool flag2 = false;
                for (int i = 1; i <= p.Length - 1; i++)
                {
                    if (p[i].ProcessName == "WindowsFormsApp1")   //任务管理器应用程序的名
                    {
                        WriteLine("那个男人还活着!!!!");
                        flag2 = true;
                        
                    }
                }
                if(!flag2)
                {
                    WriteLine("那个男人死掉了!!!");
                    pr.Start();
                }
                
            }
        }
    }
}
