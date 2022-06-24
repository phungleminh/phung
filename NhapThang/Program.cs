using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThang
{
    class Program
    {
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Nhap Thang");
				int thang;
				bool kt = int.TryParse(Console.ReadLine(), out thang);
				if (kt == false)
				{
					throw new Exception("Ban nhap khong dung dinh dang");
				}
				if (thang <= 0 || thang > 12)
				{
					throw new Exception("Ban nhap khong dung thang");
				}
				
				//1 , 3 , 5 , 7 , 8 , 10 , 12 => 31 ngày
				//4 , 6 , 9 , 11 => 30 ngày
				//2 => 28,29 ngày
				int nam;
				if (thang == 2)
				{
					Console.WriteLine("nam la:");
					kt = int.TryParse(Console.ReadLine(), out nam);
				
				if (nam % 4 == 0)
				{
					Console.WriteLine("29 ngay");
				}
					else
				{
					Console.WriteLine("28 ngay");
				}
				}
					
				else
				{ 
					int ngay = 31;
					if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
					{
						ngay = 30;
					}
					Console.WriteLine("So Ngay: {0}", ngay);
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
