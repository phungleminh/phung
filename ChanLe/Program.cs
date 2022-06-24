using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap A");
            a = int.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("La so chan");

            }else
            {
                Console.WriteLine("La so le");

            }
            Console.ReadKey();

        }
    }
}
