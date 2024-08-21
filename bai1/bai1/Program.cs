using System;
using System.Security.Cryptography;

namespace Bai1 
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a, b;
            while (true) 
            {
                Console.Write("Nhap so thu nhat: ");
                if (int.TryParse(Console.ReadLine(), out a) == true) 
                    break;
                else { Console.WriteLine("Du lieu khong hop le.");}
            }
            while (true) 
            {
                Console.Write("Nhap so thu hai: ");
                if (int.TryParse(Console.ReadLine(), out b) == true) 
                    break;
                else { Console.WriteLine("Du lieu khong hop le.");}
            }
            int sum = a + b;
            int difference = a - b;
            double product = a * b;

            Console.WriteLine("Tong 2 so la: " + sum);
            Console.WriteLine("Hieu 2 so la: " + difference);
            Console.WriteLine("Tich 2 so la: " + product);
        }
    }
}