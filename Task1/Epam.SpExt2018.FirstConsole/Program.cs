using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.SpExt2018.FirstConsole
{
	[Flags]
	enum DaysOfWeek
	{
		Sunday,// 000000000
		Monday,// 000000001
		Tuesday,//000000010
				//000000011 Monday, Tuesday
				//000000111 /4
	}
	class Program
	{
		public static bool First()
		{
			Console.WriteLine("First");

			return false;
		}

		public static bool Second()
		{
			Console.WriteLine("Second");

			return true;
		}
		static void Main(string[] args)
		{
			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw ex;
				throw;

			}
			
		}
	}
}
