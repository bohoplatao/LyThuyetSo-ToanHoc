using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập n (tổng số phần tử): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhập r (số phần tử chọn): ");
        int r = int.Parse(Console.ReadLine());

        if (n < 0 || r < 0 || r > n)
        {
            Console.WriteLine("Vui lòng nhập giá trị hợp lệ cho n và r (0 <= r <= n).");
        }
        else
        {
            long result = Combination(n, r);
            Console.WriteLine($"Số tổ hợp C({n}, {r}) là: {result}");
        }
    }

    // Hàm tính giai thừa
    static long Factorial(int num)
    {
        if (num == 0) return 1; // 0! = 1
        long result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    // Hàm tính tổ hợp
    static long Combination(int n, int r)
    {
        return Factorial(n) / (Factorial(r) * Factorial(n - r));
    }
}
