using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            Console.Write("Nhap C: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out c))
                     break;
                Console.Write("Du lieu khong hop le, nhap lai: ");
            }
            double k = c + 273; 
            Console.WriteLine("K: " + k);
            double f = (c * 18 / 10) + 32;
            Console.WriteLine("F: " + f);
        }
    }
}
