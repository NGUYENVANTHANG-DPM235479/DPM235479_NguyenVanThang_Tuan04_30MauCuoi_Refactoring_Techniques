using System;
namespace HideMethod
{
    // TRƯỚC: Phương thức KetNoiDatabaseAccess() được để public dù chỉ dùng nội bộ
    public class CapNhatGiaAccessBefore
    {
        public void KetNoiDatabaseAccess()
        {
            Console.WriteLine("[Access DB]: Mở kết nối cơ sở dữ liệu bán hàng");
        }

        public void CapNhatGia(string maThuoc, double giaMoi)
        {
            KetNoiDatabaseAccess();
            Console.WriteLine($"[Access DB]: Đã cập nhật giá cho {maThuoc}: {giaMoi:N0} đ");
        }
    }
}