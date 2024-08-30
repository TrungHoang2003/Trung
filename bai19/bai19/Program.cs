using System;
using System.Diagnostics.CodeAnalysis;

int[] arr = { 1, 2, 3, 4, 5, 6 };

int sum = 0;

for(int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}
Console.WriteLine(sum);


