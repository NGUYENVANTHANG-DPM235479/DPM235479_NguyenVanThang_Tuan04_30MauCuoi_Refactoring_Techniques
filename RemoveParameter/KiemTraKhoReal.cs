using System;

namespace RemoveParameter
{
    public class KiemTraKhoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REMOVE PARAMETER ===");
            var before = new KiemTraKhoBefore();
            var after = new KiemTraKhoAfter();
            Console.WriteLine($"[Before - Phải truyền maVung 'AG01' thừa]: Giá xuất = {before.TinhGiaXuatKho(100000, 1.1, "AG01"):N0} đ");
            Console.WriteLine($"[After  - Bỏ tham số thừa]: Giá xuất = {after.TinhGiaXuatKho(100000, 1.1):N0} đ");
        }
    }
}