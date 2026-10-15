using System;
namespace SeparateQueryFromModifier
{
    public class QuanLyKhoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: SEPARATE QUERY FROM MODIFIER ===");
            var before = new QuanLyKhoBefore();
            Console.WriteLine($"[Before]: Gọi kiểm tra -> Tồn kho bị trừ ngay: {before.KiemTraVaXuatKho(20)} (Còn {before.SoLuongTon} chai)");

            var after = new QuanLyKhoAfter();
            if (after.DuHangDeXuat(20))
            {
                Console.WriteLine($"[After - Query]: Đủ điều kiện xuất kho (Tồn kho chưa đổi: {after.SoLuongTon})");
                after.TruTonKho(20);
                Console.WriteLine($"[After - Modifier]: Đã trừ tồn kho (Còn lại: {after.SoLuongTon})");
            }
        }
    }
}