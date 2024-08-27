using System;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 2, 6, 9, 102, 225, 123, 120 };

            int sum = 0;

            Console.Write("Mang cho truoc la: ");

            for(int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                   sum += arr[i];
                }
            }
            Console.WriteLine("\nTong cac so le trong day la: " + sum);
        }
    }
}
