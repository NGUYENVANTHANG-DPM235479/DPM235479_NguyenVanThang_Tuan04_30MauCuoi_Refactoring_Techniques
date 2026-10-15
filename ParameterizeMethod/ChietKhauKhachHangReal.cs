using System;
namespace ParameterizeMethod
{
    public class ChietKhauKhachHangReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: PARAMETERIZE METHOD ===");
            double tienHang = 10000000;
            var before = new ChietKhauKhachHangBefore();
            var after = new ChietKhauKhachHangAfter();
            Console.WriteLine($"[Before]: Cấp 1 = {before.ChietKhauDaiLyCap1(tienHang):N0} đ | Cấp 2 = {before.ChietKhauDaiLyCap2(tienHang):N0} đ");
            Console.WriteLine($"[After]:  Cấp 1 (10%) = {after.TinhChietKhau(tienHang, 0.10):N0} đ | Cấp 2 (5%) = {after.TinhChietKhau(tienHang, 0.05):N0} đ");
        }
    }
}