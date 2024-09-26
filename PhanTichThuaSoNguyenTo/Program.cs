using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt
        Console.Write("Nhập một số nguyên dương: ");
        int number = int.Parse(Console.ReadLine());

        // Kiểm tra nếu số nhập vào là số dương
        if (number <= 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương.");
        }
        else
        {
            Console.WriteLine($"Phân tích {number} thành tích các thừa số nguyên tố:");
            Factorize(number);
        }
    }

    // Hàm phân tích số nguyên thành tích các thừa số nguyên tố
    static void Factorize(int n)
    {
        // Biến để lưu các thừa số nguyên tố
        string result = "";

        // Lặp qua tất cả các số nguyên tố từ 2 đến căn bậc 2 của n
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            while (n % i == 0)
            {
                result += i + " ";  // Lưu thừa số nguyên tố vào chuỗi kết quả
                n /= i;             // Chia n cho i cho đến khi không chia hết
            }
        }

        // Nếu n vẫn lớn hơn 1, thì n chính là thừa số nguyên tố còn lại
        if (n > 1)
        {
            result += n;
        }

        // In ra kết quả các thừa số nguyên tố
        Console.WriteLine(result);
    }
}
