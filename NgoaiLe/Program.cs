using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoaiLe
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Nhap So Nguyen A");
				int a;

				bool kt = int.TryParse(Console.ReadLine(), out a);
				Console.WriteLine("a là {0}", a);
				if(kt == false)
				{
					//không phải số nguyên
					throw new Exception("Ban nhap khong dung!"); 
				}
				

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
		}
	}

}
