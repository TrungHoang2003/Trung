using System;

namespace Bai11
{
    class Program
    {
        static int input(int n)
        {
            while (true) 
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("Du lieu khong hop le, nhap lai: ");
            }
            return n;
        }

        static void Main(string[] args)
        {
            int n=0;
            Console.Write("Nhap do dai day so: ");

            n = input(n);

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap so thu " + (i+1) + ": ");
                arr[i] = input(arr[i]);
            }

            for(int i = 0;i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int sum=0;
            for(int i = 0; i<n;i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("\nTong cua day so la: " + sum);
        }
    }
}