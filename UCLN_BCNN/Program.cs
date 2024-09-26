using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt

        // Nhập hai số nguyên từ bàn phím
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        // Tính UCLN và BCNN
        int ucln = GCD(a, b);  // Tìm UCLN bằng hàm GCD
        int bcnn = LCM(a, b, ucln);  // Tìm BCNN bằng hàm LCM

        // Hiển thị kết quả
        Console.WriteLine($"Ước chung lớn nhất (UCLN) của {a} và {b} là: {ucln}");
        Console.WriteLine($"Bội chung nhỏ nhất (BCNN) của {a} và {b} là: {bcnn}");
    }

    // Hàm tính UCLN bằng phương pháp Euclid
    static int GCD(int a, int b)
    {
        // Đảm bảo a và b đều là số dương
        a = Math.Abs(a);
        b = Math.Abs(b);

        // Thuật toán Euclid
        while (b != 0)
        {
            int temp = b;
            b = a % b;  // Lấy phần dư của a và b
            a = temp;
        }
        return a;  // a là UCLN sau khi b = 0
    }

    // Hàm tính BCNN dựa vào UCLN
    static int LCM(int a, int b, int gcd)
    {
        // BCNN = (|a * b|) / UCLN
        return Math.Abs(a * b) / gcd;
    }
}
