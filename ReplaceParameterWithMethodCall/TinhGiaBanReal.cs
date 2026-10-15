using System;
namespace ReplaceParameterWithMethodCall
{
    public class TinhGiaBanReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE PARAMETER WITH METHOD CALL ===");
            var before = new TinhGiaBanBefore();
            var after = new TinhGiaBanAfter();
            Console.WriteLine($"[Before - Bên ngoài phải tự truyền 0.05]: {before.TinhTienHang(200000, 0.05):N0} đ");
            Console.WriteLine($"[After  - Tự gọi hàm nội bộ tính giảm]:   {after.TinhTienHang(200000):N0} đ");
        }
    }
}