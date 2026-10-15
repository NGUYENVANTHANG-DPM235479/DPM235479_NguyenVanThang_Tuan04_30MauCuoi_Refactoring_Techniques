using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeStateStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // NẾU CHỈ CHẠY RIÊNG BÀI NÀY ĐỂ TEST:
            QuanLyDonHangReal.ChayDemo();

            /* 
            // NẾU LÀM MENU CHUNG CHO CẢ ĐỒ ÁN 60 MẪU THÌ DÙNG SWITCH-CASE NHƯ SAU:
            while (true)
            {
                Console.WriteLine("\n=== MENU DEMO 60 MẪU REFACTORING - NÔNG DƯỢC AN GIANG ===");
                Console.WriteLine("1. Replace Type Code with State/Strategy (Quản lý đơn hàng)");
                Console.WriteLine("2. Mẫu tiếp theo...");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn mẫu muốn chạy demo: ");
                
                string chon = Console.ReadLine();
                Console.Clear();

                switch (chon)
                {
                    case "1":
                        QuanLyDonHangReal.ChayDemo();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
            */

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
