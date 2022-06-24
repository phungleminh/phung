using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            KhaiBaoMang();
            //XuatMangRaMangHinh();
            //XuatSoChanTrongMangRaManHinh();
            //TimGiaTriLonNhatTrongMang();
            NhapMang();
            Console.ReadKey();
        }

        private static void NhapMang()
        {          
            int SoPhanTu = NhapSoNguyenDuong("Nhap so phan tu: ");
            //Nhập Mảng
            int[] a = new int[SoPhanTu];
            //Khai Báo Mảng
            for (int i = 0; i < SoPhanTu; i++)
            {
                a[i] = NhapSoNguyenDuong("Nhap Phan Tu Thu " + i+1);
                //a[i] = NhapSoNguyenDuong(string.Format("Nhap Phan Tu Thu {0}",i+1));

            }
            //Xuất Mảng
            for (int i = 0; i < SoPhanTu; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static int NhapSoNguyenDuong(string thongbao)
        {
            int a;
            bool kt;
            Console.WriteLine(thongbao);
            do
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == true)
                    if (a <= 0)
                    {
                        kt = false;
                    }
                if (kt == false)
                {
                    Console.WriteLine("Nhap lai");
                }
            }
            while (kt == false);

            return a;
        }

        private static void TimGiaTriLonNhatTrongMang()
        {
            int[] a = { 45, 78, 12, 23, 56, 89 };
            int max = a[0];

            for (int i = 0; i < a.Length; i++)               
            if (max < a[i])
                max = a[i];

            //for (int i = 0; i < a.Length; i++)
               // Console.WriteLine(a[i]);

            Console.WriteLine("Max la:{0}",max);
        }

        private static void XuatSoChanTrongMangRaManHinh()
        {
            int[] a = { 45, 78, 12, 23, 56, 89 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine("{0} La So Chan",a[i]);
                }
                else
                {
                    Console.WriteLine("{0} La So Le", a[i]);

                }
            }
        }



        private static void XuatMangRaMangHinh()
        {
            int[] a = { 64, 68, 12, 36, 78 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void KhaiBaoMang()
        {
            int[] a = { 12, 46, 86, 45, 85 };
            int[] b = new int[4];
        }
    }
}
