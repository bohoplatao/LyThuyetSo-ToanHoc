using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên dương: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0.");
        }
        else
        {
            // Kiểm tra số hoàn hảo
            if (IsPerfectNumber(number))
            {
                Console.WriteLine($"{number} là số hoàn hảo.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số hoàn hảo.");
            }
        }
    }

    // Hàm kiểm tra xem một số có phải là số hoàn hảo hay không
    static bool IsPerfectNumber(int n)
    {
        int sum = 0;

        // Tính tổng các ước số dương thực sự của n
        for (int i = 1; i <= n / 2; i++)  // Duyệt từ 1 đến n/2
        {
            if (n % i == 0)  // Nếu i là ước của n
            {
                sum += i;  // Cộng ước số vào tổng
            }
        }

        // Nếu tổng các ước thực sự bằng n, thì n là số hoàn hảo
        return sum == n;
    }
}
