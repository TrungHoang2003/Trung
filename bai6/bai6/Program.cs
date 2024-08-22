using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen bat ki: ");
            int n;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("n khong phai la so nguyen, vui long nhap lai: ");
            }
            if (n % 2 == 0)
                Console.WriteLine(n + " la so chan.");
            else
                Console.WriteLine(n + " la so le.");
        }
    }
}