using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} là số thuận nghịch (đối xứng).");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số thuận nghịch (đối xứng).");
        }
    }

    // Hàm kiểm tra số thuận nghịch (đối xứng)
    static bool IsPalindrome(int n)
    {
        // Lưu trữ số gốc
        int original = n;
        int reversed = 0;

        // Đảo ngược số bằng cách lấy từng chữ số từ phải qua trái
        while (n > 0)
        {
            int digit = n % 10;    // Lấy chữ số cuối cùng
            reversed = reversed * 10 + digit;  // Thêm chữ số vào số đảo ngược
            n /= 10;    // Bỏ chữ số cuối cùng
        }

        // Kiểm tra nếu số đảo ngược bằng số gốc
        return original == reversed;
    }
}
