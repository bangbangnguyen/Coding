using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 2 cung Bangdangiu"); //in ra màn hình thoi
            Console.WriteLine("Giai phuong trinh ax^2+bx+c=0");
            //cho người dùng nhập số a, mình check điều kiện và lưu lại a
            Console.WriteLine("Nhap vao so a (khac 0)");
            string a = Console.ReadLine(); // đọc dữ liệu a mà người dùng nhập vào 
            if (double.TryParse(a, out double soa)) //check xem a có phải là số không
            {
                if (soa != 0) // nếu có, check tiếp a có khác 0 không
                {
                    Console.WriteLine($"a = {soa}, hay nhap vao b");
                    string b = Console.ReadLine(); // đọc dữ liệu b mà người dùng nhập vào
                    if (double.TryParse(b, out double sob))
                    {
                        Console.WriteLine($"b={sob}, hay nhap vao c");
                        string c = Console.ReadLine(); // đọc dữ liệu c mà người dùng nhập vào
                        if (double.TryParse(c, out double soc))
                        {
                            //tính delta 
                            double delta = Math.Pow(sob, 2) - 4 * soa * soc;
                            if (delta > 0)
                            { double x1 = (-sob + Math.Sqrt(delta)) / (2 * soa);
                                double x2 = (-sob - Math.Sqrt(delta)) / (2 * soa);
                                Console.WriteLine($"Phuong trinh co 2 nghiem thuc phan biet x1 = {x1} va x2 = {x2}");
                            }
                            else
                            {
                                if (delta < 0)
                                { Console.WriteLine("Tam thoi vo nghiem thuc, chua tinh so phuc dau"); }
                                else
                                {
                                    //change
                                    double x = - sob / (2 * soa);
                                    Console.WriteLine($"Phuong trinh co 1 nghiem kep la x = {x} ");
                                }
                            }
                        }
                        else { Console.WriteLine("Hãy nhập số c hợp lệ"); }
                    }
                    else { Console.WriteLine("Hãy nhập số b hợp lệ"); }
                }
                else { Console.WriteLine("Hãy nhập số khác 0"); }
            }
            else { Console.WriteLine("Hãy nhập số a hợp lệ"); }
        }
    }

}
