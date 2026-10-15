using System;
namespace HideMethod
{
    public class CapNhatGiaAccessReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: HIDE METHOD ===");
            var after = new CapNhatGiaAccessAfter();
            // Client chỉ cần gọi hàm CapNhatGia, chi tiết kết nối đã được ẩn giấu (Encapsulation)
            after.CapNhatGia("ANVIL-5SC", 125000);
        }
    }
}