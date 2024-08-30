using DataAccess.DO;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            int choice = 0;
            ValidateData.input("Nhap lua chon cua ban: ", ref choice);
            switch (choice)
            {
                case 1:
                    int n = 0;
                    ValidateData.input("Nhap so luong sinh vien: ", ref n);
                    Struct.SinhVien[] dssinhvien = new Struct.SinhVien[n];
                    DataAcess.ListSinhVienInput(ref dssinhvien);
                    DataAcess.ListSinhVienOutput(dssinhvien);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Lua chon k hop le, hay nhap lai: ");
                    break;
            }
        }

    }
}