using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        ref int max = ref FindMax(numbers);
        Console.WriteLine("Gia tri lon nhat: " + max);
        
    }

    static ref int FindMax(int[] array)
    {
        ref int max = ref array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
                max = array[i];
        }
        return ref max;   
    }
}
