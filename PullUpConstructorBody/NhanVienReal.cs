using System;
namespace PullUpConstructorBody
{
    public class NhanVienReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: PULL UP CONSTRUCTOR BODY ===");
            var nv = new NhanVienBanHangAfter("NV01", "Nguyễn Văn Thắng", 50000000);
            Console.WriteLine($"[Pull Up Constructor]: NV: {nv.MaNV} - {nv.HoTen} (Doanh số: {nv.DoanhSo:N0} đ)");
        }
    }
}