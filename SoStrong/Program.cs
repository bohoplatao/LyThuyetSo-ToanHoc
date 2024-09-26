//Số Strong (hay còn gọi là số mạnh hoặc số siêu mạnh) là một số nguyên dương mà tổng giai thừa của các chữ số của nó bằng chính nó
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên dương: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0.");
        }
        else
        {
            // Kiểm tra số Strong
            if (IsStrongNumber(number))
            {
                Console.WriteLine($"{number} là số Strong.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số Strong.");
            }
        }
    }

    // Hàm kiểm tra số Strong
    static bool IsStrongNumber(int n)
    {
        int originalNumber = n;  // Lưu lại giá trị gốc để so sánh sau này
        int sum = 0;

        // Lặp qua từng chữ số của n
        while (n > 0)
        {
            int digit = n % 10;  // Lấy chữ số cuối cùng
            sum += Factorial(digit);  // Tính giai thừa của chữ số và cộng vào tổng
            n /= 10;  // Bỏ chữ số cuối cùng
        }

        // Nếu tổng các giai thừa bằng với số ban đầu, thì đó là số Strong
        return sum == originalNumber;
    }

    // Hàm tính giai thừa của một số nguyên dương
    static int Factorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}

