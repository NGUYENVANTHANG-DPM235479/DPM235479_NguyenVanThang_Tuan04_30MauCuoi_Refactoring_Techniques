using System;
namespace ExtractSubclass
{
    public class DonHangReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: EXTRACT SUBCLASS ===");
            var donThuy = new DonHangDuongThuyAfter { TienHang = 5000000, PhiGheXuong = 150000 };
            Console.WriteLine($"[Extract Subclass]: Đơn vận chuyển đường thủy miền Tây -> Tổng: {donThuy.TinhTongTien():N0} đ");
        }
    }
}