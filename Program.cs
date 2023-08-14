using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            char cont = 'y';
            do
            {
                Console.WriteLine ("\nChon hanh dong.");
                Console.WriteLine ("0. Nhap so n.\n1. Thoat");
                Console.Write ("Chon: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    Console.Write("Nhap vao so n: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Chon hanh dong.");
                    Console.WriteLine("0. Bai 1 - Kiem tra xem so co chia het cho 3 khong?");
                    Console.WriteLine("1. Bai 2 - Hien thi bang cuu chuong tu 1 den n.");
                    Console.WriteLine("2. Bai 3 - Tinh tong giai thua tu 1 den n.");
                    Console.WriteLine("3. Bai 4 - Kiem tra so co phai la so chinh phuong khong?");
                    Console.WriteLine("4. Bai 5 - Tim so ngay co trong thang.");
                    Console.WriteLine("5. Bai 6 - Tinh tong binh phuong.");
                    Console.WriteLine("6. Bai 7 - Tinh tong cac so le tu 1 den n.");
                    Console.WriteLine("7. Bai 8 - Hien thi cac so nguyen to tu 1 den n.");
                    Console.WriteLine("8. Bai 9 - Ve tam giac vuong.");
                    Console.WriteLine("9. Bai 10 - Hien thi day Fibonacci tu 1 den n.");
                    Console.WriteLine("10. Thoat.");
                    Console.Write("Chon: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    
                    switch(y)
                    {
                        case 0:
                            Bai1.ktChiaHetCho3(n); break;
                        case 1:
                            Bai2.hienThiBangCuuChuong(n); break;
                        case 2:
                            Bai3.tinhTongGiaiThua(n); break;
                        case 3:
                            Bai4.ktSoChinhPhuong(n); break;
                        case 4:
                            Bai5.hienThiNgayTrongThang(n); break;
                        case 5:
                            Bai6.tinhTongBinhPhuong(n); break;
                        case 6:
                            Bai7.tinhTongCacSoLe(n); break;
                        case 7:
                            Bai8.hienThiSoNguyenTo(n); break;
                        case 8:
                            Bai9.veTamGiacVuong(n); break;
                        case 9:
                            Bai10.hienThiDayFibonacci(n); break;
                        case 10:
                            Environment.Exit(0);
                            break;
                    }

                    Console.Write("Ban co muon tiep tuc? (y/n): ");
                    cont = Console.ReadKey(true).KeyChar;
                }
                else
                {
                    Environment.Exit(0);
                }
            } while(cont == 'y');
        }
    }
}
