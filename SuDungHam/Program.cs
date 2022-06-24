using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //XinChao();
            //XinChao("Teo");
            //PhuongTrinhBac1();
            //PhuongTrinhBac2();

            //Console.ReadKey();

        }

        private static void Menu()
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Phuong Trinh Bac 1");
            Console.WriteLine("2. Phuong Trinh Bac 2");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1": PhuongTrinhBac1();
                     break;
                case "2": PhuongTrinhBac2();
                    break;
                case "exit":
                    return;
            }
            Menu();
        }

        private static void PhuongTrinhBac2()
        {
            //a*x*x+b*x+c=0
            Console.WriteLine("Nhap A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Pow(b,2) - 4 * a * c;
            try
            { 
                if (d<0)
                {
                    throw new Exception("vo ngiem");
                }
                //d>=0
                
                 double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                 double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1={0}", x1,
                        @"x2={1}", x2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PhuongTrinhBac1()
        {
            //a*x+b=0;
            Console.WriteLine("Nhap A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
            double b = double.Parse(Console.ReadLine());
            if (a==0)
            {
                if (b==0)
                {
                    Console.WriteLine("vo so nghiem");
                }
                else
                {
                    Console.WriteLine("vo nghiem");
                }

            }
            else
            {
                Console.WriteLine("x = {0}", -b/a);
            }

        }

        private static void XinChao(string hoten)
        {
            Console.WriteLine("Xin Chao: {0}", hoten);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin chao");
        }
    }
}
