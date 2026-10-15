using System;
namespace HideMethod
{
    // SAU: Ẩn (Hide Method) phương thức kết nối thành private, chỉ phơi bày API nghiệp vụ
    public class CapNhatGiaAccessAfter
    {
        private void KetNoiDatabaseAccess()
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