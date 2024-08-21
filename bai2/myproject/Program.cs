using System;
namespace HelloWorld
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("giai phuong trinh bac 1");
            Console.Write("nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine()); 
            double x = -b/a;
            Console.WriteLine("Ket qua: " + x);
           
        }
   }
} 