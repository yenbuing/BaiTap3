using System;
public class Bai10
{
    public static void hienThiDayFibonacci(int n)
    {
        int a = 0; 
        int b = 1;
        int next = 0;
        int i = 2;

        Console.WriteLine("Day Fibonacci voi {0} phan tu: ", n);
        Console.Write("{0}\t{1}\t", a, b);
        next = a + b;

        while (i < n)
        {
            Console.Write("{0}\t", next);
            a = b;
            b = next;
            next = a + b;
            i++;
        }
        Console.WriteLine();
    }     
}