using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeStateStrategy
{
    public class QuanLyDonHangReal
    {
        // Đổi từ Main sang ChayDemo() để Program.cs gọi tới
        public static void ChayDemo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("============================================================");
            Console.WriteLine("   MẪU: REPLACE TYPE CODE WITH STATE/STRATEGY               ");
            Console.WriteLine("   Nghiệp vụ: Quản lý Đơn hàng Sỉ & Lẻ Nông dược An Giang   ");
            Console.WriteLine("============================================================\n");

            // --- PHẦN 1: CHẠY CODE BEFORE (Dùng Type Code cũ) ---
            Console.WriteLine("1. [TRƯỚC REFACTOR - Dùng biến int Type Code & switch-case]:");
            var donHangCu = new QuanLyDonHangBefore("HD-OLD-01", 2000000, 20000, QuanLyDonHangBefore.BAN_LE);
            Console.WriteLine($"   - Lúc mua lẻ (2 triệu) -> Tổng tiền: {donHangCu.TinhTongThanhToan():N0} VNĐ");

            // Khách mua thêm hàng, đổi trực tiếp biến int
            donHangCu.TienHang = 15000000;
            donHangCu.LoaiDonHang = QuanLyDonHangBefore.BAN_SI;
            Console.WriteLine($"   - Đổi sang mua sỉ (15 triệu) -> Tổng tiền: {donHangCu.TinhTongThanhToan():N0} VNĐ\n");


            // --- PHẦN 2: CHẠY CODE AFTER (Đã áp dụng State/Strategy) ---
            Console.WriteLine("2. [SAU REFACTOR - Đã thay bằng đối tượng LoaiDonHangState]:");
            var hoaDonMoi = new QuanLyDonHangAfter(
                maHoaDon: "HD-AG-2026-001",
                tienHang: 2000000,
                phiDichVuPhu: 20000,
                loaiDonHangCode: LoaiDonHangState.BAN_LE
            );

            Console.WriteLine("   * Trạng thái 1: Khách mua lẻ ban đầu");
            InChiTietHoaDon(hoaDonMoi);

            Console.WriteLine("\n   * Trạng thái 2: Khách mua thêm phân bón lên 15 triệu -> Cắm State BÁN SỈ vào");
            hoaDonMoi.TienHang = 15000000;
            hoaDonMoi.SetLoaiDonHang(LoaiDonHangState.BAN_SI);
            InChiTietHoaDon(hoaDonMoi);

            Console.WriteLine("\n   * Trạng thái 3: Khách trình thẻ Đại lý Cấp 1 -> Cắm State ĐẠI LÝ CẤP 1 vào");
            hoaDonMoi.SetLoaiDonHang(LoaiDonHangState.DAI_LY_CAP_1);
            InChiTietHoaDon(hoaDonMoi);
        }

        private static void InChiTietHoaDon(QuanLyDonHangAfter hd)
        {
            Console.WriteLine($"     + Mã HĐ: {hd.MaHoaDon} | Loại: {hd.GetTenLoaiDon()} (Code: {hd.GetLoaiDonHang()})");
            Console.WriteLine($"     + Tiền hàng: {hd.TienHang:N0}đ | Chiết khấu: -{hd.TinhChietKhau():N0}đ | Ship: +{hd.TinhPhiVanChuyen():N0}đ | Phụ phí: +{hd.PhiDichVuPhu:N0}đ");
            Console.WriteLine($"     => TỔNG THANH TOÁN: {hd.TinhTongThanhToan():N0} VNĐ");
        }
    }
}
