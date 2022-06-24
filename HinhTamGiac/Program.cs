using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap canh A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh C");
            double c = double.Parse(Console.ReadLine());
            double chuvi = a + b + c;

            double p = chuvi / 2;
            double s = Math.Sqrt(Math.Sqrt(p*(p - a) * (p - b) * (p - c)));
            Console.WriteLine("Chu vi la {0}", chuvi,
            @"Dien tich la {1}", s);

            Console.ReadKey();
        }
        
        
    }
}
