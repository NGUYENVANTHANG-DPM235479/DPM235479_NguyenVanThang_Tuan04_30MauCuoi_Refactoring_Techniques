using System;
namespace RemoveSettingMethod
{
    public class LoHangNongDuocReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REMOVE SETTING METHOD ===");
            var before = new LoHangNongDuocBefore("LO-2026-01");
            before.MaLo = "LO-BI-SUA"; // Có thể bị sửa đổi ngoài ý muốn
            Console.WriteLine($"[Before]: Mã lô bị sửa đổi thành: {before.MaLo}");

            var after = new LoHangNongDuocAfter("LO-2026-01");
            // after.MaLo = "..." -> Lỗi biên dịch vì đã bỏ setter!
            Console.WriteLine($"[After]: Mã lô là thuộc tính Read-only bất biến: {after.MaLo}");
        }
    }
}