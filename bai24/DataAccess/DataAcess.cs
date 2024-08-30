using DataAccess.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


public static class DataAcess
{
    public static void sinhVienInput(ref Struct.SinhVien sinhvien)
    {
        ValidateData.input("Nhap ten sinh vien: ", ref sinhvien.ten);
        ValidateData.input("Nhap id: ", ref sinhvien.id);
        ValidateData.input("Nhap tuoi: ", ref sinhvien.tuoi);
        ValidateData.input("Nhap diem tong ket hoc ki 1: ", ref sinhvien.diemTK1);
        ValidateData.input("Nhap diem tong ket hoc ki 2: ", ref sinhvien.diemTK2);
        Console.WriteLine();
    }

    public static void sinhVienOutput(Struct.SinhVien sinhvien)
    {
        Console.WriteLine("Ten sinh vien: " + sinhvien.ten);
        Console.WriteLine("ID: " + sinhvien.id);
        Console.WriteLine("Tuoi: " + sinhvien.tuoi);
        Console.WriteLine("Diem tong ket hoc ki 1: " + sinhvien.diemTK1);
        Console.WriteLine("Diem tong ket hoc ki 2: " + sinhvien.diemTK2);
        Console.WriteLine() ;
    }

    public static void ListSinhVienInput(ref Struct.SinhVien[] dssinhvien)
    {
        for (int i = 0; i < dssinhvien.Length; i++)
        {
            Console.WriteLine("nhap thong tin sinh vien thu " + (i + 1) + ": ");
            sinhVienInput(ref dssinhvien[i]);
        }
        Console.WriteLine();
    }

    public static void ListSinhVienOutput(Struct.SinhVien[] dssinhvien)
    {
        for(int i = 0;i< dssinhvien.Length;i++)
        {
            sinhVienOutput(dssinhvien[i]);
        }
        Console.WriteLine();
    }

}

