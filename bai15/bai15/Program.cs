using System;
 int[] arr = { 1, 2, 3, 4, 5, 5, 6 };

change(ref arr[1], 7);
Console.Write(arr[1]);
static void change(ref int x, int y)
{
    x = y;  
}