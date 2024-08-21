using System;

namespace Bai1 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Giai tich, hieu, tong cua 2 so");
            Console.Write("nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int difference = a - b;
            double product = a * b;

            Console.WriteLine("Tong 2 so la: " + sum);
            Console.WriteLine("hieu 2 so la: " + difference);
            Console.WriteLine("Tich 2 so laL "+ product);
        }
    }
}