using System;
using System.Text;
namespace ReplaceParameterWithExplicitMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            XuatKhoTheoLoReal.ChayDemo();
            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            try { Console.ReadKey(); } catch { }
        }
    }
}