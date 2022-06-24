using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhập 3 số nguyên từ bàn phím 
            int a, b, c;
            Console.WriteLine("Nhập A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập C");
            c = int.Parse(Console.ReadLine());
            // làm sao tìm số lớn nhất trong 3 số
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }

            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine("Số lớn nhất là: {0}", max);
            Console.WriteLine("Số bé nhất là: {0}", min);

            Console.ReadKey();
        }
    }
}
