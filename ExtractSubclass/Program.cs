using System;
using System.Text;
namespace ExtractSubclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DonHangReal.ChayDemo();
            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            try { Console.ReadKey(); } catch { }
        }
    }
}