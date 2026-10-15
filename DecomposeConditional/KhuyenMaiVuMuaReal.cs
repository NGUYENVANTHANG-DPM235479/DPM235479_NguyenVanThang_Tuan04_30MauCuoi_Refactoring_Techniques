using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional
{
    public class KhuyenMaiVuMuaReal
    {
        public static void ChayDemo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================================================================================");
            Console.WriteLine("       MẪU REFACTORING: DECOMPOSE CONDITIONAL                                   ");
            Console.WriteLine("       (Phân rã khối lệnh điều kiện phức tạp thành các phương thức rõ nghĩa)    ");
            Console.WriteLine("       Hệ thống: Quản lý Bán hàng & Kho - Công ty Nông dược An Giang           ");
            Console.WriteLine("================================================================================\n");

            // =====================================================================================
            // BÀI TOÁN 1: HÓA ĐƠN TRỢ GIÁ VỤ ĐÔNG XUÂN & PHÍ VẬN CHUYỂN
            // =====================================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("BÀI TOÁN 1: TÍNH TIỀN HÓA ĐƠN THEO MÙA VỤ & HỖ TRỢ VẬN CHUYỂN NÔNG DÂN");
            Console.WriteLine("--------------------------------------------------------------------------------");

            // 1. Chạy với Code Before
            Console.WriteLine("\n[1. TRƯỚC REFACTOR - Khối if-else lồng ghép phức tạp, khó đọc, khó bảo trì]");
            var hdBefore1 = new KhuyenMaiVuMuaBefore("HD-DX-01", new DateTime(2026, 12, 10), 20000000, 50, 150000, 50000);
            var hdBefore2 = new KhuyenMaiVuMuaBefore("HD-NT-02", new DateTime(2026, 6, 15), 8000000, 10, 80000, 30000);

            Console.WriteLine($"   * Đơn 1 (Ngày 10/12/2026 - Mùa vụ Đông Xuân, 50 bao phân, 20tr):");
            Console.WriteLine($"     -> Tổng thanh toán: {hdBefore1.TinhTongTienThanhToan():N0} VNĐ");

            Console.WriteLine($"   * Đơn 2 (Ngày 15/06/2026 - Ngày thường, 10 bao phân, 8tr):");
            Console.WriteLine($"     -> Tổng thanh toán: {hdBefore2.TinhTongTienThanhToan():N0} VNĐ");
            Console.WriteLine("   => NHƯỢC ĐIỂM: Biểu thức if dài ngoằng, không rõ ý đồ nghiệp vụ là gì!");


            // 2. Chạy với Code After
            Console.WriteLine("\n[2. SAU REFACTOR - Phân rã thành LaTrongDotTroGiaVuDongXuan(), TinhTienTroGia(), TinhTienNgayThuong()]");
            var hdAfter1 = new KhuyenMaiVuMuaAfter("HD-DX-01", new DateTime(2026, 12, 10), 20000000, 50, 150000, 50000);
            var hdAfter2 = new KhuyenMaiVuMuaAfter("HD-NT-02", new DateTime(2026, 6, 15), 8000000, 10, 80000, 30000);

            InChiTietHoaDonAfter(hdAfter1);
            InChiTietHoaDonAfter(hdAfter2);


            // =====================================================================================
            // BÀI TOÁN 2: XUẤT KHO NÔNG DƯỢC CẬN DATE (FEFO) - GIẢM GIÁ XẢ KHO THU HỒI VỐN
            // =====================================================================================
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("BÀI TOÁN 2: XUẤT KHO LÔ THUỐC BVTV CẬN HẠN DÙNG (Yêu cầu quản lý phân lô & hạn dùng)");
            Console.WriteLine("--------------------------------------------------------------------------------");

            DateTime ngayHienTai = new DateTime(2026, 10, 15);
            var loThuoc1 = new LoHangNongDuoc("LO-ANVIL-01", "Thuốc trừ nấm Anvil 5SC", new DateTime(2026, 11, 20), 80, 120000);
            var loThuoc2 = new LoHangNongDuoc("LO-TILTSUPER-02", "Thuốc trừ bệnh Tilt Super 300EC", new DateTime(2027, 8, 10), 200, 180000);

            Console.WriteLine($"   * Ngày kiểm kho xuất hàng: {ngayHienTai:dd/MM/yyyy}");

            InThongTinXuatKho(loThuoc1, ngayHienTai);
            InThongTinXuatKho(loThuoc2, ngayHienTai);

            Console.WriteLine("\n================================================================================");
            Console.WriteLine(" KẾT LUẬN:");
            Console.WriteLine(" - Biểu thức điều kiện phức tạp được phân rã thành các hàm có tên tự giải thích.");
            Console.WriteLine(" - Code dễ đọc, dễ mở rộng quy tắc trợ giá mùa vụ và quản lý lô hàng cận date.");
            Console.WriteLine("================================================================================");
        }

        private static void InChiTietHoaDonAfter(KhuyenMaiVuMuaAfter hd)
        {
            Console.WriteLine($"   * Mã HĐ: {hd.MaHoaDon} | Ngày lập: {hd.NgayLap:dd/MM/yyyy} | Tiền hàng: {hd.TienHang:N0}đ");
            Console.WriteLine($"     + Kiểm tra điều kiện: {(hd.LaTrongDotTroGiaVuDongXuan() ? "✔ ĐƯỢC TRỢ GIÁ VỤ ĐÔNG XUÂN" : "✖ TÍNH GIÁ TIÊU CHUẨN NGÀY THƯỜNG")}");
            if (hd.LaTrongDotTroGiaVuDongXuan())
            {
                Console.WriteLine($"     + Chiết khấu trợ giá (8%): -{hd.TinhChietKhauVuMua():N0}đ");
                Console.WriteLine($"     + Phí vận chuyển hỗ trợ: +{hd.TinhPhiVanChuyenTroGia():N0}đ (Gốc: {hd.PhiVanChuyen:N0}đ)");
            }
            else
            {
                Console.WriteLine($"     + Chiết khấu ngày thường: -{hd.TinhChietKhauNgayThuong():N0}đ");
                Console.WriteLine($"     + Phí vận chuyển đầy đủ: +{hd.PhiVanChuyen:N0}đ");
            }
            Console.WriteLine($"     => TỔNG THANH TOÁN: {hd.TinhTongTienThanhToan():N0} VNĐ\n");
        }

        private static void InThongTinXuatKho(LoHangNongDuoc lo, DateTime ngayXuat)
        {
            int soNgayCon = (lo.NgayHetHan - ngayXuat).Days;
            bool laCanDate = lo.LaLoHangCanDateCanXaKho(ngayXuat);

            Console.WriteLine($"   -------------------------------------------------------------");
            Console.WriteLine($"   * Mã Lô: {lo.MaLo} | Sản phẩm: {lo.TenThuocBVTV}");
            Console.WriteLine($"     + Hạn sử dụng: {lo.NgayHetHan:dd/MM/yyyy} (Còn {soNgayCon} ngày) | Tồn kho: {lo.SoLuongTon} chai/gói");
            Console.WriteLine($"     + Trạng thái: {(laCanDate ? "⚠ LÔ CẬN DATE -> Áp dụng xả kho giảm 25%" : "✔ HẠN DÙNG AN TOÀN -> Bán giá niêm yết")}");
            Console.WriteLine($"     + Đơn giá xuất kho: {lo.TinhGiaXuatKho(ngayXuat):N0} VNĐ (Giá gốc: {lo.DonGiaGoc:N0} VNĐ)");
        }
    }
}
