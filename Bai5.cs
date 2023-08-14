using System;

public class Bai5
{
    public static void hienThiNgayTrongThang(int n)
    {
        int day = 0;
        Console.WriteLine("Kiem tra 1 thang co bao nhieu ngay.");
        Console.WriteLine("-----------------------------------");

        switch(n)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12: 
                day = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:   
                day = 30;
                break; 
            case 2:
                Console.Write("Nhap vao nam: ");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0 || (year % 400 == 0 && year % 100 == 0)) 
                {
                    day = 29;
                }
                else{day = 28;}
                break;
            default:
                break;
        }
        if (day == 0)
        {
            Console.WriteLine("Thang khong ton tai. Thang phai nam trong khoang tu 1 den 12.");
        }
        else
        {
            Console.WriteLine("Thang {0} co {1} ngay.", n, day);
        }    
    }
}