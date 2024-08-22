using System;

namespace Bai9
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

            for (int i=0;i<n;i++)
            {
                Console.Write("Nhap phan tu thu " + (i+1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = 0;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("Day sap xep tang dan: ");
            for (int i = 0; i < n; i++)
            {
                    Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = 0;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Day sap xep giam dan: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        // 2 9 8 1
    }
}