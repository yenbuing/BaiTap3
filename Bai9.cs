using System;
public class Bai9
{
    public static void veTamGiacVuong(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }     
}
