using System;
namespace PullUpMethod
{
    public class HoaDonReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: PULL UP METHOD ===");
            var si = new HoaDonBanSiAfter { TienHang = 10000000 };
            var le = new HoaDonBanLeAfter { TienHang = 2000000 };
            Console.WriteLine($"[Pull Up Method]: Thuế sỉ (10tr) = {si.TinhThueVAT():N0} đ | Thuế lẻ (2tr) = {le.TinhThueVAT():N0} đ");
        }
    }
}