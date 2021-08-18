using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;

namespace Galactic_Bypass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
			Console.Title = "Galactic";
			string str = string.Empty;
			string text = string.Empty;
			foreach (string text2 in args)
			{
				bool flag = text2.Contains("-epicusername=");
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				if (flag4)
				{
					str = text2.Replace("-epicusername=", "");
				}
				text = text + text2 + " ";
			}

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[Galactic]");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Loading.. " + str);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[Galactic]");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Made By .exo#9999");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[Galactic]");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Was Loaded.");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[Galactic]");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Is preparing to launch..");
			Process.Start("FortniteClient-Win64-Shipping.exe", text);


			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
                bool flag5 = process.ProcessName.Contains("FortniteClient-Win64-Shipping");
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				if (flag8)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("[Galactic]");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" Has Been Launched.");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("[Galactic]");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" Have fun with Galactic <3");

					break;
				}
			}
			Console.Read();
		}
	}
}

