using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields
{
    // =========================================================================================
    // MẪU REFACTORING: REPLACE SUBCLASS WITH FIELDS (Thay thế lớp con bằng các trường dữ liệu)
    // 
    // GIẢI PHÁP:
    // 1. Loại bỏ hoàn toàn tất cả các lớp con rườm rà (NhanVienBanHang, ThuKho, KeToan, QuanLy).
    // 2. Chuyển các hàm trả về hằng số thành các trường dữ liệu (fields) bên trong lớp cha duy nhất.
    // 3. Khởi tạo các fields này qua Constructor hoặc thông qua các Static Factory Methods.
    // 
    // LỢI ÍCH TRONG ĐỒ ÁN NÔNG DƯỢC AN GIANG:
    // - Loại bỏ Code Smell Lazy Class và kế thừa phân cấp dư thừa.
    // - Dễ dàng mở rộng, tạo thêm vai trò mới (như Giám sát đại lý, Nhân viên giao hàng)
    //   hoặc nạp động trực tiếp từ CSDL Microsoft Access mà KHÔNG cần phải viết thêm class mới.
    // - Tích hợp đầy đủ vào chức năng: Phân quyền đăng nhập, duyệt giảm giá hóa đơn, chỉ định lô xuất kho.
    // =========================================================================================

    public class NhanVienAfter
    {
        // Thông tin định danh nhân viên
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public double LuongCoBan { get; set; }

        // CÁC FIELDS ĐÃ THAY THẾ CHO CÁC SUBCLASSES TRƯỚC ĐÂY
        private readonly string _tenChucVu;
        private readonly string _maNhomQuyen;
        private readonly double _tyLeHoaHong;
        private readonly bool _coQuyenDuyetGiamGia;
        private readonly bool _coQuyenXuatKhoChiDinh;

        // Constructor tổng quát: Nhận các fields trực tiếp
        public NhanVienAfter(
            string maNV, 
            string hoTen, 
            string tenDangNhap, 
            double luongCoBan,
            string tenChucVu,
            string maNhomQuyen,
            double tyLeHoaHong,
            bool coQuyenDuyetGiamGia,
            bool coQuyenXuatKhoChiDinh)
        {
            MaNhanVien = maNV;
            HoTen = hoTen;
            TenDangNhap = tenDangNhap;
            LuongCoBan = luongCoBan;

            _tenChucVu = tenChucVu;
            _maNhomQuyen = maNhomQuyen;
            _tyLeHoaHong = tyLeHoaHong;
            _coQuyenDuyetGiamGia = coQuyenDuyetGiamGia;
            _coQuyenXuatKhoChiDinh = coQuyenXuatKhoChiDinh;
        }

        // Properties công khai để truy xuất thông tin (thay thế cho abstract methods trước kia)
        public string TenChucVu => _tenChucVu;
        public string MaNhomQuyen => _maNhomQuyen;
        public double TyLeHoaHong => _tyLeHoaHong;
        public bool CoQuyenDuyetGiamGia => _coQuyenDuyetGiamGia;
        public bool CoQuyenXuatKhoChiDinh => _coQuyenXuatKhoChiDinh;

        // =====================================================================================
        // STATIC FACTORY METHODS: Cách khởi tạo thay thế các constructor của các lớp con cũ
        // Giúp mã nguồn gọi rõ ràng, tiện lợi và không bị phá vỡ tính tương thích
        // =====================================================================================

        public static NhanVienAfter TaoNhanVienBanHang(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
        {
            return new NhanVienAfter(
                maNV, hoTen, tenDangNhap, luongCoBan,
                tenChucVu: "Nhân viên Bán hàng Nông dược",
                maNhomQuyen: "BAN_HANG",
                tyLeHoaHong: 0.03, // 3% hoa hồng doanh số bán thuốc/phân bón
                coQuyenDuyetGiamGia: false,
                coQuyenXuatKhoChiDinh: false
            );
        }

        public static NhanVienAfter TaoThuKho(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
        {
            return new NhanVienAfter(
                maNV, hoTen, tenDangNhap, luongCoBan,
                tenChucVu: "Thủ kho Nông dược An Giang",
                maNhomQuyen: "THU_KHO",
                tyLeHoaHong: 0.005, // 0.5% phụ cấp xuất nhập lô
                coQuyenDuyetGiamGia: false,
                coQuyenXuatKhoChiDinh: true // Được quyền chỉ định lô xuất kho
            );
        }

        public static NhanVienAfter TaoKeToan(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
        {
            return new NhanVienAfter(
                maNV, hoTen, tenDangNhap, luongCoBan,
                tenChucVu: "Kế toán Chi nhánh",
                maNhomQuyen: "KE_TOAN",
                tyLeHoaHong: 0.01,
                coQuyenDuyetGiamGia: false,
                coQuyenXuatKhoChiDinh: false
            );
        }

        public static NhanVienAfter TaoQuanLyChiNhanh(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
        {
            return new NhanVienAfter(
                maNV, hoTen, tenDangNhap, luongCoBan,
                tenChucVu: "Quản lý Chi nhánh An Giang",
                maNhomQuyen: "ADMIN_CHI_NHANH",
                tyLeHoaHong: 0.05, // 5% hoa hồng quản lý
                coQuyenDuyetGiamGia: true,  // Có quyền duyệt giảm giá, chiết khấu hóa đơn
                coQuyenXuatKhoChiDinh: true // Có quyền phê duyệt chỉ định lô xuất kho
            );
        }

        // ĐIỂM SÁNG: Cho phép nạp vai trò động từ Cơ sở dữ liệu Access mà không cần code thêm class!
        public static NhanVienAfter TaoTuCauHinhCSDL(
            string maNV, string hoTen, string tenDangNhap, double luongCoBan,
            string tenChucVu, string maNhomQuyen, double tyLeHoaHong, bool duyetGiamGia, bool xuatChiDinh)
        {
            return new NhanVienAfter(
                maNV, hoTen, tenDangNhap, luongCoBan,
                tenChucVu, maNhomQuyen, tyLeHoaHong, duyetGiamGia, xuatChiDinh
            );
        }

        // =====================================================================================
        // CÁC HÀNH VI NGHIỆP VỤ LIÊN QUAN TRONG ĐỒ ÁN NÔNG DƯỢC
        // =====================================================================================

        public double TinhThuNhap(double doanhSoThang)
        {
            return LuongCoBan + (doanhSoThang * _tyLeHoaHong);
        }

        public bool KiemTraQuyenDuyetGiamGia()
        {
            return _coQuyenDuyetGiamGia;
        }

        public bool KiemTraQuyenXuatKhoChiDinh()
        {
            return _coQuyenXuatKhoChiDinh;
        }
    }
}
