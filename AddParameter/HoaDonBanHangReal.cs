using System;
namespace AddParameter
{
    public class HoaDonBanHangReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: ADD PARAMETER ===");
            var before = new HoaDonBanHangBefore();
            var after = new HoaDonBanHangAfter();
            Console.WriteLine($"[Before]: Không có giảm giá -> Tổng = {before.TinhTongTien(5000000):N0} đ");
            Console.WriteLine($"[After - Thêm tham số chiết khấu 200k]: Tổng = {after.TinhTongTien(5000000, 200000):N0} đ");
        }
    }
}