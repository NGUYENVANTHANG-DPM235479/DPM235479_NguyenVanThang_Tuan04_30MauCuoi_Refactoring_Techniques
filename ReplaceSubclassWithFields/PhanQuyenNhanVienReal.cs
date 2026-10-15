using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields
{
    public class PhanQuyenNhanVienReal
    {
        public static void ChayDemo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================================================================================");
            Console.WriteLine("       MẪU REFACTORING: REPLACE SUBCLASS WITH FIELDS                            ");
            Console.WriteLine("       (Thay thế các lớp con thừa thãi bằng các trường dữ liệu - Fields)        ");
            Console.WriteLine("       Hệ thống: Quản lý Bán hàng & Phân quyền - Công ty Nông dược An Giang    ");
            Console.WriteLine("================================================================================\n");

            // =====================================================================================
            // BÀI TOÁN 1: QUẢN LÝ NHÂN VIÊN & PHÂN QUYỀN ĐĂNG NHẬP / DUYỆT GIẢM GIÁ / XUẤT KHO LÔ
            // =====================================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("BÀI TOÁN 1: PHÂN QUYỀN NHÂN VIÊN (Yêu cầu chức năng đăng nhập & phân quyền đồ án)");
            Console.WriteLine("--------------------------------------------------------------------------------");

            // --- PHẦN 1: TRƯỚC REFACTOR (BEFORE) ---
            Console.WriteLine("\n[1. TRƯỚC REFACTOR - Sử dụng kế thừa rườm rà với nhiều lớp con rỗng]");
            NhanVienBefore nvCu1 = new NhanVienBanHangBefore("NV01", "Nguyễn Văn Thắng", "thang_nv", 6000000);
            NhanVienBefore nvCu2 = new QuanLyChiNhanhBefore("QL01", "Trần Thị Lan", "lan_ql", 15000000);

            Console.WriteLine($"   * {nvCu1.HoTen} - Chức vụ: {nvCu1.GetTenChucVu()}");
            Console.WriteLine($"     + Quyền duyệt giảm giá: {(nvCu1.CoQuyenDuyetGiamGia() ? "Được phép" : "Không có quyền")}");
            Console.WriteLine($"     + Lương & hoa hồng (doanh số 200tr): {nvCu1.TinhThuNhap(200000000):N0} VNĐ");

            Console.WriteLine($"   * {nvCu2.HoTen} - Chức vụ: {nvCu2.GetTenChucVu()}");
            Console.WriteLine($"     + Quyền duyệt giảm giá: {(nvCu2.CoQuyenDuyetGiamGia() ? "Được phép" : "Không có quyền")}");
            Console.WriteLine($"     + Lương & hoa hồng (doanh số 200tr): {nvCu2.TinhThuNhap(200000000):N0} VNĐ");
            Console.WriteLine("   => NHƯỢC ĐIỂM: Thêm mỗi chức vụ mới phải tạo 1 class mới, không thể gán quyền động!");

            // --- PHẦN 2: SAU REFACTOR (AFTER) ---
            Console.WriteLine("\n[2. SAU REFACTOR - Gom thành các fields trong lớp NhanVien duy nhất + Factory Methods]");
            
            // Khởi tạo thông qua Factory Methods sạch sẽ
            var nvMoiBanHang = NhanVienAfter.TaoNhanVienBanHang("NV01", "Nguyễn Văn Thắng", "thang_nv", 6000000);
            var nvMoiThuKho = NhanVienAfter.TaoThuKho("TK01", "Lê Văn Hùng", "hung_kho", 7000000);
            var nvMoiQuanLy = NhanVienAfter.TaoQuanLyChiNhanh("QL01", "Trần Thị Lan", "lan_ql", 15000000);

            // ĐIỂM ĐẶC BIỆT: Tạo vai trò mới ngay trong Runtime từ CSDL Access mà không cần tạo class mới!
            var nvGiaoHangMoi = NhanVienAfter.TaoTuCauHinhCSDL(
                "GH01", "Phạm Văn Bình", "binh_ship", 6500000,
                tenChucVu: "Nhân viên Giao vận Nông dược",
                maNhomQuyen: "GIAO_HANG",
                tyLeHoaHong: 0.015,
                duyetGiamGia: false,
                xuatChiDinh: false
            );

            List<NhanVienAfter> danhSachNV = new List<NhanVienAfter> 
            { 
                nvMoiBanHang, 
                nvMoiThuKho, 
                nvMoiQuanLy, 
                nvGiaoHangMoi 
            };

            double doanhSoChung = 200000000; // 200 triệu tiền bán thuốc BVTV, phân bón
            Console.WriteLine("\n   DANH SÁCH NHÂN VIÊN & KIỂM TRA PHÂN QUYỀN:");
            foreach (var nv in danhSachNV)
            {
                Console.WriteLine($"   -------------------------------------------------------------");
                Console.WriteLine($"   * Mã NV: {nv.MaNhanVien} | Họ tên: {nv.HoTen} | Chức vụ: {nv.TenChucVu}");
                Console.WriteLine($"     + Nhóm quyền hệ thống: [{nv.MaNhomQuyen}]");
                Console.WriteLine($"     + Quyền duyệt chiết khấu/giảm giá: {(nv.KiemTraQuyenDuyetGiamGia() ? "✔ CÓ QUYỀN" : "✖ KHÔNG")}");
                Console.WriteLine($"     + Quyền chỉ định lô xuất kho: {(nv.KiemTraQuyenXuatKhoChiDinh() ? "✔ CÓ QUYỀN (Theo chỉ định)" : "✖ KHÔNG (Chỉ xuất FIFO)")}");
                Console.WriteLine($"     + Tỷ lệ hoa hồng: {nv.TyLeHoaHong * 100:F1}% => Tổng thu nhập: {nv.TinhThuNhap(doanhSoChung):N0} VNĐ");
            }


            // =====================================================================================
            // BÀI TOÁN 2: CẤU HÌNH DỊCH VỤ PHÁT SINH & PHÍ VẬN CHUYỂN HÓA ĐƠN NÔNG DƯỢC
            // =====================================================================================
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("BÀI TOÁN 2: DỊCH VỤ PHÁT SINH & CHI PHÍ VẬN CHUYỂN (Chức năng hóa đơn trong đồ án)");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("\n[Áp dụng Replace Subclass with Fields cho các loại dịch vụ phụ trên hóa đơn]:");
            var phiShip = DichVuPhatSinhAfter.TaoPhiVanChuyen();
            var phiBocXep = DichVuPhatSinhAfter.TaoPhiBocXep();
            var phiBaoQuan = DichVuPhatSinhAfter.TaoPhiBaoQuanKhoLanh();

            // Dịch vụ phụ nạp thêm từ cơ sở dữ liệu
            var phiKiemDinh = DichVuPhatSinhAfter.TaoTuCauHinh("Phí kiểm định dư lượng hóa chất", "Mẫu", 150000, true);

            Console.WriteLine($"   1. {phiShip.TenDichVu}: 2 chuyến -> Thành tiền (VAT 10%): {phiShip.TinhThanhTien(2):N0} VNĐ");
            Console.WriteLine($"   2. {phiBocXep.TenDichVu}: 50 bao -> Thành tiền: {phiBocXep.TinhThanhTien(50):N0} VNĐ");
            Console.WriteLine($"   3. {phiBaoQuan.TenDichVu}: 3 ngày -> Thành tiền (VAT 10%): {phiBaoQuan.TinhThanhTien(3):N0} VNĐ");
            Console.WriteLine($"   4. {phiKiemDinh.TenDichVu}: 1 mẫu -> Thành tiền (VAT 10%): {phiKiemDinh.TinhThanhTien(1):N0} VNĐ");

            Console.WriteLine("\n================================================================================");
            Console.WriteLine(" KẾT LUẬN:");
            Console.WriteLine(" - Đã loại bỏ hàng loạt subclass thừa, gom gọn code thành các fields.");
            Console.WriteLine(" - Dễ dàng áp dụng cho nhiều bài toán khác nhau trong đồ án: Phân quyền đăng nhập,");
            Console.WriteLine("   thống kê nhân viên, dịch vụ phát sinh, phí vận chuyển.");
            Console.WriteLine("================================================================================");
        }
    }
}
