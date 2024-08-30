using System;

int[] arr = { -1, 5, -9, 6, 8, 1, -8 };

int maxCurrent = arr[0];
int maxGlobal = arr[0];
int s = 0, end = 0, start = 0;

for(int i = 1;i < arr.Length; i++)
{
    if (arr[i] > maxCurrent + arr[i])
    {
        s = i;
        maxCurrent = arr[i];
    }
    else
        maxCurrent += arr[i];

    if(maxGlobal > maxCurrent)
    {
        maxGlobal = maxCurrent;
        start = s;
        end = i; 
    }
}

Console.Write(arr[s]);

