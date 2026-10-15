using System;
namespace PreserveWholeObject
{
    public class VanChuyenHangReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: PRESERVE WHOLE OBJECT ===");
            var donHang = new DonHangNongDuoc();
            var before = new VanChuyenHangBefore();
            var after = new VanChuyenHangAfter();
            Console.WriteLine($"[Before - truyền lẻ tẻ tienHang, soKm]: Phí = {before.TinhCuocVanChuyen(donHang.TienHang, donHang.KhoangCachKm):N0} đ");
            Console.WriteLine($"[After  - truyền nguyên DonHang]:        Phí = {after.TinhCuocVanChuyen(donHang):N0} đ");
        }
    }
}