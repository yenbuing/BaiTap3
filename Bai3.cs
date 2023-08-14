using System;

public class Bai3
{
    private static int giaiThua(int n)
    {
        int factorial = 1;
        if (n == 0 || n == 1)
        {
            factorial = 1;
        }
        else
        {
            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }
        }
        return factorial;
    }
    public static void tinhTongGiaiThua(int n)
    {
        int s = 0; // Tong

        Console.WriteLine("Tinh tong giai thua tu 1 den n.");
        Console.WriteLine("--------------------------------");


        for (int i = 0; i <= n; i++)
        {
            s = s + giaiThua(i);
        }
        Console.WriteLine("Tong giai thua tu 1 den {0} la {1}.", n, s);
    }
}