using System;

namespace IntroduceNullObject
{
    public class DichVuVanChuyenReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: INTRODUCE NULL OBJECT ===");
            Console.WriteLine("Nghiệp vụ: Quản lý chi phí vận chuyển & dịch vụ phụ trên hóa đơn\n");

            double tienHang = 2000000;

            // Khách không đăng ký dịch vụ ship
            var hdBefore = new HoaDonBefore { DichVuShip = null };
            var hdAfter = new HoaDonAfter(); // Tự động dùng NullDichVuVanChuyen

            Console.WriteLine("1. Khi khách hàng KHÔNG dùng dịch vụ vận chuyển:");
            Console.WriteLine($"   [Before]: Dịch vụ = '{hdBefore.LayTenDichVu()}' | Tổng = {hdBefore.TinhTongTien(tienHang):N0} đ");
            Console.WriteLine($"   [After] : Dịch vụ = '{hdAfter.LayTenDichVu()}' | Tổng = {hdAfter.TinhTongTien(tienHang):N0} đ");

            // Khách có đăng ký dịch vụ ship
            var hdCoShip = new HoaDonAfter(new DichVuVanChuyenThat());
            Console.WriteLine("\n2. Khi khách hàng CÓ dùng dịch vụ vận chuyển:");
            Console.WriteLine($"   [After] : Dịch vụ = '{hdCoShip.LayTenDichVu()}' | Tổng = {hdCoShip.TinhTongTien(tienHang):N0} đ");
        }
    }
}
