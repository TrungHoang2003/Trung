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
                Console.WriteLine("Vui long nhap so nguyen duong:");
            }

            if (n <= 1)
                Console.WriteLine(n + " khong phai la so nguyen to.");
            else
            {
                bool isPrime = KiemTraSoNguyenTo(n);
                if (isPrime)
                {
                    Console.WriteLine(n + " la so nguyen to");
                }
                else
                    Console.WriteLine(n + " khong phai la so nguyen to");
            }

        }
    }
}