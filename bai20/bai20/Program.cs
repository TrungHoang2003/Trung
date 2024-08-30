using System;
using System.Linq.Expressions;

int[] arr = { 1, 2, 3, 4,5,6,7,8,9,10,11,12,13,14,15,16};

int temp = 0;

for (int i = 0; i < arr.Length/2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = temp;

 }

for(int i = 0; i<arr.Length; i++)
{
    Console.WriteLine(arr[i]);  
}