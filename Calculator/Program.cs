using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is simple Calculator project !
            int choice = 0;
            do
            {
                Console.WriteLine("======May tinh ca nhan======");
                Console.WriteLine("1/ Cong hai so");
                Console.WriteLine("2/ Tru hai so");
                Console.WriteLine("3/ Nhan hai so");
                Console.WriteLine("4/ Chia hai so");
                Console.WriteLine("5/ Chia lay du");
                Console.WriteLine("6/ Tinh a^b ");
                Console.WriteLine("0/ Thoat");
                Console.WriteLine("Ban chon?");

                choice = Convert.ToInt32(Console.ReadLine());
                int a = 0, b = 0;
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Hen gap lai");
                        break;

                    case 1:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen  b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;

                    case 2:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;

                    case 3:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen  b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;

                    case 4:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen  b");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b==0)
                        {
                            Console.WriteLine("Mau so b phai khac 0");
                            continue;
                        }
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;

                    case 5:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen  b");
                        b = Convert.ToInt32(Console.ReadLine());
                        if(b==0)
                        {
                            Console.WriteLine("Mau so b phai khac 0");
                            continue;
                        }
                        Console.WriteLine($"{a} % {b} = {a % b}");
                        break;

                    case 6:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen  b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
                        break;

                    default:
                        Console.WriteLine("Nhap tu 1 den 6");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
