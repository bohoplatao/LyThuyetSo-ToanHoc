//Tam giác Pascal là một cấu trúc hình tam giác các số nguyên, trong đó mỗi số là tổng của hai số ngay phía trên nó. Tam giác Pascal có nhiều ứng dụng trong xác suất, tổ hợp, và lý thuyết số.
//Mỗi hàng trong tam giác đại diện cho các hệ số của khai triển nhị thức (a+b)^n (Hằng đẳng thức )

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Thiết lập mã hóa để hiển thị tiếng Việt
        Console.Write("Nhập số hàng của tam giác Pascal: ");
        int n = int.Parse(Console.ReadLine());

        PrintPascalTriangle(n);
    }

    // Hàm in ra Tam giác Pascal
    static void PrintPascalTriangle(int n)
    {
        for (int line = 0; line < n; line++)
        {
            int C = 1;  // Khởi tạo hệ số đầu tiên
            Console.Write(new string(' ', (n - line) * 2)); // Căn giữa

            for (int i = 0; i <= line; i++)
            {
                Console.Write(C + " "); // In hệ số
                C = C * (line - i) / (i + 1); // Tính hệ số tiếp theo
            }

            Console.WriteLine(); // Xuống dòng sau mỗi hàng
        }
    }
}

