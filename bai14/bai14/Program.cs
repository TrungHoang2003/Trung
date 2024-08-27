using System;

int a, b;
a = 1;

b = 2;
swap(ref a, ref b);
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
