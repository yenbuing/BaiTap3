using System;

public class Bai4
{
    public static void ktSoChinhPhuong(int n)
    {
        int y = 0;
        string result = "la";

        Console.WriteLine("Cho biet so nhap vao co phai so chinh phuong hay khong?");

        y = Convert.ToInt32(Math.Sqrt(n));
        if (n != y * y)
        {
            result = "khong la";
        }
        Console.WriteLine("{0} {1} so chinh phuong", n, result);
    }
    
}