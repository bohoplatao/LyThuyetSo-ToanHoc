//Dãy số Fibonacci bắt đầu bằng 0 và 1, và mỗi số tiếp theo là tổng của hai số trước đó
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập số lượng số Fibonacci cần in ra: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0.");
        }
        else
        {
            Console.WriteLine($"Dãy số Fibonacci đầu tiên gồm {n} số là:");
            PrintFibonacci(n);
        }
    }

    // Hàm in ra n số Fibonacci đầu tiên
    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1;  // Khởi tạo hai số đầu tiên của dãy Fibonacci

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");  // In số hiện tại
            int next = a + b;  // Tính số tiếp theo
            a = b;  // Cập nhật số a
            b = next;  // Cập nhật số b
        }
    }
}

