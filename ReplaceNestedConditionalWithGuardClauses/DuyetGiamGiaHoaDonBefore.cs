using System;

namespace ReplaceNestedConditionalWithGuardClauses
{
    // TRƯỚC REFACTOR: Các câu lệnh if lồng nhau sâu (Arrow anti-pattern),
    // khiến luồng xử lý chính bị thụt lề nhiều cấp và khó đọc.
    public class DuyetGiamGiaHoaDonBefore
    {
        public double TinhTienGiamGia(bool daDangNhap, bool coQuyenQuanLy, bool hoaDonHopLe, double tongTien)
        {
            double ketQua = 0;

            if (daDangNhap)
            {
                if (coQuyenQuanLy)
                {
                    if (hoaDonHopLe)
                    {
                        // Logic chính nằm sâu tít bên trong
                        ketQua = tongTien * 0.10; // Giảm giá 10%
                    }
                    else
                    {
                        ketQua = 0;
                    }
                }
                else
                {
                    ketQua = 0;
                }
            }
            else
            {
                ketQua = 0;
            }

            return ketQua;
        }
    }
}
