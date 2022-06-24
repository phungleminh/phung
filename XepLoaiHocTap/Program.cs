using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap diem:");
            double diem = double.Parse(Console.ReadLine());
            if (diem >= 0 && diem < 3.5)
            {
                Console.WriteLine("Ket qua: Kem");
            }
            else if (diem < 5)
            {
                Console.WriteLine("Ket qua: Yeu");
            }
            else if (diem < 6.5)
            {
                Console.WriteLine("Ket qua: TB");
            }
            else if (diem < 8.5)
            {
                Console.WriteLine("Ket qua: Kha");
            }
            else

            {
                Console.WriteLine("Ket qua: Gioi");
            }
                  

            Console.ReadKey();
        }
        
    }
}
