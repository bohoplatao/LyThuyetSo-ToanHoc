using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên để kiểm tra: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên không âm.");
        }
        else
        {
            if (IsFibonacci(number))
            {
                Console.WriteLine($"{number} là số Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số Fibonacci.");
            }
        }
    }

    // Hàm kiểm tra số Fibonacci
    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;

        // Tiếp tục tính các số Fibonacci cho đến khi vượt quá n
        while (a < n)
        {
            int next = a + b;  // Tính số Fibonacci tiếp theo
            a = b;  // Cập nhật a
            b = next;  // Cập nhật b
        }

        // Nếu a bằng n, n là số Fibonacci
        return a == n;
    }
}
