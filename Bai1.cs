using System;

public class Bai1
{
    public static void ktChiaHetCho3(int n)
    {
        Console.WriteLine("Kiem tra so nguyen co chia het cho 3 hay không ?");
        Console.WriteLine("---------------------------------");
        
        string result = "chia het";
        if (n % 3 != 0)
        {
            result = "khong chia het";
        }
        Console.WriteLine("{0} {1} cho 3", n, result);
    }
}