using System;
    public class Bai6
    {
        public static void tinhTongBinhPhuong(int n)
        {
            double s = 0;

            for (double i = 0; i <= n; i++)
            {
                s = s + Math.Pow(i, 2);
            }

            Console.WriteLine("S = {0}", s);
        }
    }