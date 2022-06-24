using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapWhileTT
{
    class Program
    {
        static void Main(string[] args)
        {
            //UocChungLonNhat();
            //XacDinhSoNguyenTo();
            //XacDinhSoNguyenToWhile();
            //int a = NhapSoNguyen();
            int a = NhapSoNguyenDuong();

            Console.WriteLine("So Nguyen duong a la {0}",a);
            Console.ReadKey();

        }

        private static int NhapSoNguyenDuong()
        {
            int a;
            bool kt;
            Console.WriteLine("So Nguyen duong la ");
            do
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == true)
                    if (a<=0)
                    {
                        kt = false;
                    }
                if (kt == false)
                {
                    Console.WriteLine("Nhap lai");
                }    
            } 
            while (kt==false);
            
            return a;
        }

        private static int NhapSoNguyen()
        {
            int a;
            Console.WriteLine("Nhap so nguyen:");
            while(int.TryParse(Console.ReadLine(),out a) == false)
            {
                Console.WriteLine("Nhap lai");
            }    
            return a;
        }

        private static void XacDinhSoNguyenToWhile()
        {
            Console.WriteLine("Nhap so nguyen A: ");
            int i = 2;
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                if (n % i == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine("{0} la so nguyen to", n);
                    }

                    else

                    {
                        Console.WriteLine("{0} khong la so nguyen to", n);

                    }
                    break;

                }
                i++;
            }
        }
        private static void XacDinhSoNguyenTo()
        {
            Console.WriteLine("Nhap so nguyen N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % 1 == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine("{0} la so nguyen to", n);
                    }
                    else
                    {
                        Console.WriteLine("{0} khong la so nguyen to", n);
                    }
                    break;

                }
            }
        }
        private static void UocChungLonNhat()
        {
            Console.WriteLine("Nhap A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B: ");
            int b = int.Parse(Console.ReadLine());
            while (a * b > 0)
            {
                if (a < b)
                {
                    b = b % a;
                }
                else
                {
                    a = a % b;
                }
            }
            Console.WriteLine("Uoc chung lon nhat la:{0} ", a + b);

        }
    }
}

