using System;
using System.Text;
namespace PullUpConstructorBody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVienReal.ChayDemo();
            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            try { Console.ReadKey(); } catch { }
        }
    }
}