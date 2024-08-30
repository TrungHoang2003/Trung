using System;

int[] arr = { 1, 5, 2, 6, 3 };

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
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

Console.WriteLine("Phan tu lon nhat trong mang la: " + arr[0]);
Console.WriteLine("Phan tu lon thu hai trong mang la: " + arr[1]);
