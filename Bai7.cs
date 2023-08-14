using System;
    public class Bai7
    {
        public static void tinhTongCacSoLe(int n)
        {
            int s = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    continue;
                }
                s = s + i;
            }
            Console.WriteLine("Tong cac so tu 1 den {0} la {1}.", n, s);
        }
    }