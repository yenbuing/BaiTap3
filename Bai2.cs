using System;

public class Bai2
{
    public static void hienThiBangCuuChuong(int n)
    {
        Console.WriteLine("In bang cuu chuong.");
        Console.WriteLine("---------------------------------");

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0} * {1} = {2}\n", i, j, i * j);
            }
            Console.WriteLine();
        }
    }
}