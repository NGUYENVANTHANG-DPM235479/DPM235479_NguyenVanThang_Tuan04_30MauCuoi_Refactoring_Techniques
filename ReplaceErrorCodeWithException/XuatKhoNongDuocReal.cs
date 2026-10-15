using System;
namespace ReplaceErrorCodeWithException
{
    public class XuatKhoNongDuocReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE ERROR CODE WITH EXCEPTION ===");
            var before = new XuatKhoNongDuocBefore();
            int code = before.XuatHang(50);
            Console.WriteLine($"[Before]: Xuất 50 gói phân bón -> Trả về mã lỗi: {code}");

            var after = new XuatKhoNongDuocAfter();
            try
            {
                after.XuatHang(50);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"[After]: Bắt ngoại lệ chuẩn -> {ex.Message}");
            }
        }
    }
}