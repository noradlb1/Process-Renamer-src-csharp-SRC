using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Console = Colorful.Console;

namespace RzyRenamer
{
	class Program
	{
		[DllImport("user32.dll")]
		static extern int SetWindowText(IntPtr hWnd, string newtitle);

		public static void BackMenu()
		{
			Console.Title = Utils.RandomString();
			Console.Clear();
			int r = 225;
			int g = 255;
			int b = 250;
			//				
			Console.WriteLine(@"				  ___  ______   __  ___ ___ _  _   _   __  __ ___ ___ ", Color.FromArgb(r, g, b));
			r -= 28;
			b -= 19;
			Console.WriteLine(@"				 | _ \|_  /\ \ / / | _ \ __| \| | /_\ |  \/  | __| _ \", Color.FromArgb(r, g, b));
			r -= 28;
			b -= 19;
			Console.WriteLine(@"				 |   / / /  \ V /  |   / _|| .` |/ _ \| |\/| | _||   /", Color.FromArgb(r, g, b));
			r -= 28;
			b -= 19;
			Console.WriteLine(@"				 |_|_\/___|  |_|   |_|_\___|_|\_/_/ \_\_|  |_|___|_|_\", Color.FromArgb(r, g, b));
			r -= 28;
			b -= 19;
			Console.WriteLine("\n\n\nEnter the process name that you want to rename:", Color.FromArgb(r, g, b));
			r -= 28;
			b -= 19;
			string process = Console.ReadLine();
			Console.WriteLine("Enter the name that you want as title:", Color.FromArgb(r, g, b));
			r -= 28;
			b -= 19;
			string title = Console.ReadLine();
			 

			Process processtorename = Process.GetProcessesByName(process)[0];
			if (processtorename != null)
			{
				SetWindowText(processtorename.MainWindowHandle, title);
				Console.WriteLine("Successfully renamed !", Color.FromArgb(r, g, b));
				r -= 28;
				b -= 19;
				Console.WriteLine("U'll be redirected to the home in 5 seconds.", Color.FromArgb(r, g, b));
				Thread.Sleep(5000);
				BackMenu();

			}
			else
			{
				Console.WriteLine($"{process} is not running/ is null(or)empty!", Color.FromArgb(r, g, b));
			}

			Console.ReadLine();
		}
		static void Main(string[] args)
		{
			BackMenu();
		}

		

	}
}
