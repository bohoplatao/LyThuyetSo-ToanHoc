
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectSquare(number))
        {
            Console.WriteLine($"{number} là số chính phương.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số chính phương.");
        }
    }

    // Hàm kiểm tra số chính phương
    static bool IsPerfectSquare(int n)
    {
        // Nếu n < 0 thì không phải số chính phương
        if (n < 0)
        {
            return false;
        }

        // Tìm căn bậc 2 của n
        int sqrt = (int)Math.Sqrt(n);

        // Kiểm tra xem bình phương của sqrt có bằng n hay không
        return sqrt * sqrt == n;
    }
}
