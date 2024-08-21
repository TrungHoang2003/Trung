using System;
namespace HelloWorld
{ 
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1. Giai pt bac 1");
                Console.WriteLine("2. Giai pt bac 2");
                Console.WriteLine("3. Thoat");
                Console.Write("Nhap lua chon: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        giaiPTbac1();
                        break;
                    case 2:
                        giaiPTbac2();
                        break;
                    case 3:
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Du lieu nhap khong hop le");
                        break;
                }
                Console.WriteLine();
            }    
        }
        static void giaiPTbac1()
        {
            double a, b;
            Console.WriteLine("giai phuong trinh bac 1");
            while (true)
            {
                Console.Write("Nhap a:");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Du lieu khong hop le");
            }
            while (true)
            {
                Console.Write("Nhap b: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("Du lieu khong hop le");
            }
            double x = -b/a;
            Console.WriteLine("Ket qua: " + x);
        }
        static void giaiPTbac2()
        {
            double a, b, c;
            Console.WriteLine("giai phuong trinh bac 1");
            while (true)
            {
                Console.Write("Nhap a:");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Du lieu khong hop le");
            }
            while (true)
            {
                Console.Write("Nhap b: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("Du lieu khong hop le");
            }
            while (true)
            {
                Console.Write("Nhap c: ");
                if (double.TryParse(Console.ReadLine(), out c))
                    break;
                Console.WriteLine("Du lieu khong hop le");
            }
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                double x2 = (-b - Math.Sqrt(delta) / (2 * a));
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = " + x1 + ", x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: x = " + x);
            }
            else
                Console.WriteLine("phuong trinh vo nghiem");
        }
    }
} 