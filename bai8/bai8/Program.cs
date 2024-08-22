using System;

namespace Bai8
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
            int n = 0;
            Console.Write("Nhap so phan tu cua mang: ");
            n = input(n);

            int[] arr = new int[n]; 

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + (i+1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.Write("Cac phan tu le cua mang: ");
            for(int i = 0;i < n; i++)
            {
                if (arr[i] % 2 !=0)
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Cac phan tu chan cua mang: ");
            for(int i = 0;i < n; i++)
            {
                if (arr[i] % 2 ==0)
                Console.Write(arr[i] + " ");
            }
        }
    }
}