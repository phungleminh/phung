using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHamTT
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }

        private static void menu()
        {       
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Su dung vong lap");
            Console.WriteLine("2. Tim so lon nhat");
            Console.WriteLine("3. Tinh tong cac so tu 1 -> 1/n");
            Console.WriteLine("4. Tinh N!");
            Console.WriteLine("5. Tinh tong tu 1 den n");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    SuDungVongLap();
                    break;
                case "2":
                    TimSoLonNhat();
                    break;
                case "3":
                    TinhTongTu1Den1ChiaN();
                    break;
                case "4":
                    TinhNGiaiThua();
                    break;
                case "5":
                    TinhTongDenN();
                    break;
                case "exit":
                    return;
            }
            menu();

        }

        private static void TinhTongTu1Den1ChiaN()
        {
            try
            {
                Console.WriteLine("Nhap so nguyen N: ");
                int n;
                bool kt = int.TryParse(Console.ReadLine(), out n);
                if (kt == false)
                {
                    throw new Exception("Chuỗi không đúng định dạng");
                }
                if (n <= 0)
                {
                    throw new Exception("N phải lớn hơn 0");
                }
                double tong = 0;
                for (int i = 0; i <= n; i++)
                {
                    tong = tong + 1.0/i;
                }
                Console.WriteLine("N:{0}", tong);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TinhNGiaiThua()
        {
            try
            {
                Console.WriteLine("Nhap so nguyen N: ");
                int n;
                bool kt = int.TryParse(Console.ReadLine(),out n);
                if (kt == false)
                {
                    throw new Exception("Chuỗi không đúng định dạng");
                }
                if (n<=0)
                {
                    throw new Exception("N phải lớn hơn 0");
                }
                int giaithua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaithua = giaithua * i;
                }
                Console.WriteLine("N:{0}", giaithua);
            }
            catch (Exception ex)           
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TinhTongDenN()
        {
            try
            {
                Console.WriteLine("Nhap so N: ");
                int n = int.Parse(Console.ReadLine());
                int tong = 0;
                for (int i = 1; i <=n ; i++)
                {
                    tong = tong + i;
                }
                Console.WriteLine("Tong den N la: {0}", tong);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TimSoLonNhat()
        {
            int a, b, c;
            Console.WriteLine("Nhap A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C");
            c = int.Parse(Console.ReadLine());         
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("So lon nhat là: {0}", max);
        }

        private static void SuDungVongLap()
        {

            Console.WriteLine("Nhap vong lap: ");
            string a = Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {                         
                Console.WriteLine(a);
            }
        }
    }
}
