using System;
namespace ReplaceConstructorWithFactoryMethod
{
    public class NhanVienNongDuocReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE CONSTRUCTOR WITH FACTORY METHOD ===");
            var nv1 = NhanVienNongDuocAfter.TaoNhanVienBanHang();
            var nv2 = NhanVienNongDuocAfter.TaoThuKho();
            Console.WriteLine($"Khởi tạo qua Factory: {nv1.ChucVu} & {nv2.ChucVu}");
        }
    }
}