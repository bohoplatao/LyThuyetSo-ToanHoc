//Bậc của một số nguyên tố p trong n! (giai thừa của n) được định nghĩa là số lần mà p xuất hiện trong phân tích nguyên tố của n!
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên tố p: ");
        int p = int.Parse(Console.ReadLine());

        if (n < 0 || p <= 1 || !IsPrime(p))
        {
            Console.WriteLine("Vui lòng nhập giá trị hợp lệ cho n và p (p phải là số nguyên tố).");
        }
        else
        {
            int degree = PrimePowerInFactorial(n, p);
            Console.WriteLine($"Bậc của số nguyên tố {p} trong {n}! là: {degree}");
        }
    }

    // Hàm tính bậc của số nguyên tố p trong giai thừa n!
    static int PrimePowerInFactorial(int n, int p)
    {
        int degree = 0;
        int power = p;

        while (power <= n)
        {
            degree += n / power;
            power *= p; // Tính p^2, p^3, ...
        }

        return degree;
    }

    // Hàm kiểm tra xem số p có phải là số nguyên tố không
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

