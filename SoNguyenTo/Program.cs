using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập một số nguyên: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số nguyên tố.");
        }
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int n)
    {
        // Nếu n nhỏ hơn 2 thì không phải là số nguyên tố
        if (n < 2)
        {
            return false;
        }

        // Kiểm tra từ 2 đến căn bậc 2 của n
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

