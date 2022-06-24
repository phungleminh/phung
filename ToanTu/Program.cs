using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap B");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong cua A va B là: {0}", a + b);
            Console.WriteLine("Hieu cua A va B là: {0}", a - b);
            Console.WriteLine("Tich cua A va B là: {0}", a * b);
            Console.WriteLine("Thuong cua A va B là: {0}", a / b);
            Console.ReadKey();



        }

    }
}
