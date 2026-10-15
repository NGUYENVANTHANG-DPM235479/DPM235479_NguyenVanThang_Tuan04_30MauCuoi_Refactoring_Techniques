using System;

namespace ReplaceNestedConditionalWithGuardClauses
{
    // SAU REFACTOR: Dùng Guard Clauses (các câu lệnh kiểm tra bảo vệ) để return sớm,
    // loại bỏ hoàn toàn việc lồng nhau của if.
    public class DuyetGiamGiaHoaDonAfter
    {
        public double TinhTienGiamGia(bool daDangNhap, bool coQuyenQuanLy, bool hoaDonHopLe, double tongTien)
        {
            // Các Guard Clauses kiểm tra điều kiện biên và return sớm
            if (!daDangNhap) return 0;
            if (!coQuyenQuanLy) return 0;
            if (!hoaDonHopLe) return 0;

            // Luồng xử lý chính được làm phẳng, không bị thụt lề
            return tongTien * 0.10; // Giảm giá 10%
        }
    }
}
