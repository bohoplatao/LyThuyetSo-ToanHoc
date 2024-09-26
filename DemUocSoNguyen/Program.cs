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
            int count = CountDivisors(number);  // Đếm số ước của số nguyên dương
            Console.WriteLine($"Số ước của {number} là: {count}");
        }
    }

    // Hàm đếm số ước của một số nguyên dương
    static int CountDivisors(int n)
    {
        int count = 0;

        // Duyệt qua từ 1 đến căn bậc 2 của n để tìm ước
        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)  // Nếu i là ước của n
            {
                if (i == n / i)  // Nếu i và n/i bằng nhau thì chỉ đếm một lần
                {
                    count++;
                }
                else  // Đếm cả cặp ước (i và n/i)
                {
                    count += 2;
                }
            }
        }

        return count;
    }
}
