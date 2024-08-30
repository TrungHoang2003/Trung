using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class ValidateData
{
    public static void input(string a, ref int n)
    {
        Console.Write(a);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
                break;
            Console.Write("Du lieu k hop le, nhap lai: ");
        }
    }
    public static void input(string a, ref double n)
    {
        Console.Write(a);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out n))
                break;
            Console.Write("Du lieu k hop le, nhap lai: ");
        }
    }
    public static void input(string a,ref string n)
    {
        Console.Write(a);
        n = Console.ReadLine();
        while (true)
        {
            if (!string.IsNullOrEmpty(n))
                break;
            Console.Write("Du lieu khong hop le, nhap lai: ");
        }
    }
}
