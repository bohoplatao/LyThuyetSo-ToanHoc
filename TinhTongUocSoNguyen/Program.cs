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
            int sum = SumOfDivisors(number);  // Tính tổng các ước của số nguyên dương
            Console.WriteLine($"Tổng các ước của {number} là: {sum}");
        }
    }

    // Hàm tính tổng các ước của một số nguyên dương
    static int SumOfDivisors(int n)
    {
        int sum = 0;

        // Duyệt qua từ 1 đến căn bậc 2 của n để tìm các ước
        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)  // Nếu i là ước của n
            {
                if (i == n / i)  // Nếu i và n/i bằng nhau thì chỉ cộng một lần
                {
                    sum += i;
                }
                else  // Cộng cả cặp ước (i và n/i)
                {
                    sum += i + (n / i);
                }
            }
        }

        return sum;
    }
}
