using System;

namespace Bai4
{

    class Program
    {
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.WriteLine("Vui long nhap so nguyen duong:" );
            }
            for (int i = 2; i < n; i++)
            {
                if(KiemTraSoNguyenTo(i))
                {
                    Console.WriteLine(i + " la so nguyen to");
                }

            } 
        }
    }
}