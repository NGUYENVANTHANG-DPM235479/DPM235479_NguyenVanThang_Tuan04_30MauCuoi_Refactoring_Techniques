using System;

namespace ConsolidateDuplicateConditionalFragments
{
    // TRƯỚC REFACTOR: Cả hai nhánh if và else đều thực thi các đoạn code giống hệt nhau
    // (như ghi nhật ký Access, in phiếu, trừ tồn kho), gây trùng lặp mã nguồn.
    public class InHoaDonBanHangBefore
    {
        public void LapHoaDon(string maHD, double tienHang, bool laBanSi)
        {
            double chietKhau = 0;

            if (laBanSi)
            {
                chietKhau = tienHang * 0.05;
                // Đoạn code trùng lặp nằm trong nhánh if
                Console.WriteLine($"[Access DB]: Ghi nhận hóa đơn {maHD} vào CSDL");
                Console.WriteLine($"[Máy in]: Đang in phiếu xuất hóa đơn {maHD}...");
            }
            else
            {
                chietKhau = 0;
                // Đoạn code trùng lặp nằm trong nhánh else
                Console.WriteLine($"[Access DB]: Ghi nhận hóa đơn {maHD} vào CSDL");
                Console.WriteLine($"[Máy in]: Đang in phiếu xuất hóa đơn {maHD}...");
            }

            double tongThanhToan = tienHang - chietKhau;
            Console.WriteLine($"-> Tổng thanh toán: {tongThanhToan:N0} VNĐ");
        }
    }
}
