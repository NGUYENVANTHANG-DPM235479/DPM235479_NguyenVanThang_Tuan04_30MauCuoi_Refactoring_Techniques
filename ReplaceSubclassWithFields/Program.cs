using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Chạy trực tiếp demo mẫu Replace Subclass with Fields
            PhanQuyenNhanVienReal.ChayDemo();

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            try
            {
                Console.ReadKey();
            }
            catch (InvalidOperationException)
            {
                // Bỏ qua nếu chạy môi trường không có phím bấm trực tiếp
            }
        }
    }
}
