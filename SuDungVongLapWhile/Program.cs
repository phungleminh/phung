﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //VongLap1();
            //XuatSoChan();
            //BangCuuChuong();

            Console.ReadKey();
        }

        private static void BangCuuChuong()
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} x {2} = {1}", i, i * j,j);
                }


            }
        }

        private static void XuatSoChan()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void VongLap1()
        {
            int index =0;
            while (index < 100)
            {
                Console.WriteLine("Xin chao");
                index++;
            }    
        }
    }
}
