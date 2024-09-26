//Số Smith là một loại số nguyên có đặc điểm là tổng các chữ số của nó bằng tổng các chữ số của các ước số nguyên tố của nó. Cụ thể, một số n
//được gọi là số Smith nếu nó không phải là số nguyên tố và tổng các chữ số của n bằng tổng các chữ số của các ước số nguyên tố của n

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên để kiểm tra: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 4)  // Số Smith phải lớn hơn 3
        {
            Console.WriteLine($"{number} không phải là số Smith.");
        }
        else
        {
            if (IsSmithNumber(number))
            {
                Console.WriteLine($"{number} là số Smith.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số Smith.");
            }
        }
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Hàm tính tổng các chữ số của một số
    static int DigitSum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    // Hàm kiểm tra số Smith
    static bool IsSmithNumber(int n)
    {
        if (IsPrime(n)) return false;  // Số Smith không phải là số nguyên tố

        int digitSum = DigitSum(n);  // Tổng các chữ số của n
        int primeFactorsSum = 0;

        // Tính các ước số nguyên tố của n
        List<int> primeFactors = GetPrimeFactors(n);
        foreach (int factor in primeFactors)
        {
            primeFactorsSum += DigitSum(factor);  // Tính tổng các chữ số của các ước số nguyên tố
        }

        return digitSum == primeFactorsSum;  // Kiểm tra tổng
    }

    // Hàm lấy các ước số nguyên tố của n
    static List<int> GetPrimeFactors(int n)
    {
        List<int> factors = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }
        return factors;
    }
}

