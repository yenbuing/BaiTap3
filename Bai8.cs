using System;
public class Bai8
{
    public static bool timSoNguyenTo(int num)
    {
        bool flag = true;
        if (num < 2)
        {
            flag = false;
        }
        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
        }
        return flag;
    }

    public static void hienThiSoNguyenTo(int n)
    {
        bool check = true;
        for (int i = 0; i < n; i++)
        {
            check = timSoNguyenTo(i);
            if (check)
            {
                Console.Write(i + "\t");
            }
        }
    }      
}
