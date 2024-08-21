using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.Write("Nhap so tu nhien n: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("ban can nhap so nguyen duong, vui long nhap lai: ");
            }
            if (n <= 1)
                Console.WriteLine(n + " khong phai la so nguyen to.");
            else
            {
                int count = 0;
                for(int i =2;i<n-1;i++)
                {
                    if (n % i == 0)
                        count += 1;
                    else
                        count = 0;
                }
                if (count == 0)
                    Console.WriteLine(n + " la so nguyen to.");
                else
                    Console.WriteLine(n + " khong phai la so nguyen to.");
            }
       }
    }
}