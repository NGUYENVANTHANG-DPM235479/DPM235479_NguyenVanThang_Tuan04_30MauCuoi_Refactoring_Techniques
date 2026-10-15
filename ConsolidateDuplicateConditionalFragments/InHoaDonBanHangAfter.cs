using System;

namespace ConsolidateDuplicateConditionalFragments
{
    // SAU REFACTOR: Đưa đoạn code trùng lặp ra ngoài cấu trúc if-else (Consolidate Duplicate Fragments).
    public class InHoaDonBanHangAfter
    {
        public void LapHoaDon(string maHD, double tienHang, bool laBanSi)
        {
            double chietKhau;

            if (laBanSi)
            {
                chietKhau = tienHang * 0.05;
            }
            else
            {
                chietKhau = 0;
            }

            // Đưa phần xử lý chung ra ngoài khối điều kiện
            Console.WriteLine($"[Access DB]: Ghi nhận hóa đơn {maHD} vào CSDL");
            Console.WriteLine($"[Máy in]: Đang in phiếu xuất hóa đơn {maHD}...");

            double tongThanhToan = tienHang - chietKhau;
            Console.WriteLine($"-> Tổng thanh toán: {tongThanhToan:N0} VNĐ");
        }
    }
}
