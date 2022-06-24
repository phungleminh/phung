using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nhap so A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so B");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Vo so nghiem");
                }
                else
                { 
                    Console.WriteLine("Vo nghiem");
                } 
            }
            else
            {
                    Console.WriteLine("x = {0;f2}", -b/a);
            }
            Console.ReadKey();
        }
    }
}
