using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields
{
    // =========================================================================================
    // CODE SMELL (MÙI MÃ NGUỒN): SUBCLASS PROLIFERATION & LAZY CLASS
    //
    // Tình trạng trước khi Refactor:
    // Lập trình viên tạo lớp trừu tượng NhanVienBefore, sau đó tạo hàng loạt lớp con kế thừa
    // như NhanVienBanHangBefore, ThuKhoBefore, KeToanBefore, QuanLyChiNhanhBefore.
    //
    // NHƯỢC ĐIỂM:
    // - Các lớp con này KHÔNG hề có logic xử lý hay thuật toán nghiệp vụ nào khác biệt.
    // - Mỗi lớp con CHỈ override các hàm để trả về giá trị hằng số cố định (Constant Methods):
    //   tên chức vụ, tỷ lệ hoa hồng, mã quyền, cờ cho phép duyệt giảm giá/chỉ định lô hàng.
    // - Dẫn đến việc sinh ra quá nhiều class con rườm rà (Subclass explosion/proliferation).
    // - Không thể lưu trữ động từ Cơ sở dữ liệu Access/SQL hay thay đổi quyền hạn khi chạy.
    // =========================================================================================

    public abstract class NhanVienBefore
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public double LuongCoBan { get; set; }

        protected NhanVienBefore(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
        {
            MaNhanVien = maNV;
            HoTen = hoTen;
            TenDangNhap = tenDangNhap;
            LuongCoBan = luongCoBan;
        }

        // Các phương thức trừu tượng chỉ trả về giá trị hằng số (Constant Methods)
        public abstract string GetTenChucVu();
        public abstract string GetMaNhomQuyen();
        public abstract double GetTyLeHoaHong();
        public abstract bool CoQuyenDuyetGiamGia();
        public abstract bool CoQuyenXuatKhoChiDinh();

        // Tính lương có cộng hoa hồng doanh số
        public double TinhThuNhap(double doanhSoThang)
        {
            return LuongCoBan + (doanhSoThang * GetTyLeHoaHong());
        }
    }

    // Lớp con 1: Nhân viên Bán hàng nông dược (chỉ trả về hằng số)
    public class NhanVienBanHangBefore : NhanVienBefore
    {
        public NhanVienBanHangBefore(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
            : base(maNV, hoTen, tenDangNhap, luongCoBan) { }

        public override string GetTenChucVu() => "Nhân viên Bán hàng Nông dược";
        public override string GetMaNhomQuyen() => "BAN_HANG";
        public override double GetTyLeHoaHong() => 0.03; // Hưởng 3% doanh số bán
        public override bool CoQuyenDuyetGiamGia() => false; // Không được tự duyệt giảm giá
        public override bool CoQuyenXuatKhoChiDinh() => false; // Không được chỉ định xuất lô hàng
    }

    // Lớp con 2: Thủ kho Nông dược (chỉ trả về hằng số)
    public class ThuKhoBefore : NhanVienBefore
    {
        public ThuKhoBefore(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
            : base(maNV, hoTen, tenDangNhap, luongCoBan) { }

        public override string GetTenChucVu() => "Thủ kho Nông dược";
        public override string GetMaNhomQuyen() => "THU_KHO";
        public override double GetTyLeHoaHong() => 0.005; // 0.5% phụ cấp xuất nhập lô
        public override bool CoQuyenDuyetGiamGia() => false;
        public override bool CoQuyenXuatKhoChiDinh() => true; // Được quyền chỉ định lô xuất kho
    }

    // Lớp con 3: Kế toán chi nhánh (chỉ trả về hằng số)
    public class KeToanBefore : NhanVienBefore
    {
        public KeToanBefore(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
            : base(maNV, hoTen, tenDangNhap, luongCoBan) { }

        public override string GetTenChucVu() => "Kế toán Chi nhánh";
        public override string GetMaNhomQuyen() => "KE_TOAN";
        public override double GetTyLeHoaHong() => 0.01;
        public override bool CoQuyenDuyetGiamGia() => false;
        public override bool CoQuyenXuatKhoChiDinh() => false;
    }

    // Lớp con 4: Quản lý chi nhánh (chỉ trả về hằng số)
    public class QuanLyChiNhanhBefore : NhanVienBefore
    {
        public QuanLyChiNhanhBefore(string maNV, string hoTen, string tenDangNhap, double luongCoBan)
            : base(maNV, hoTen, tenDangNhap, luongCoBan) { }

        public override string GetTenChucVu() => "Quản lý Chi nhánh An Giang";
        public override string GetMaNhomQuyen() => "ADMIN_CHI_NHANH";
        public override double GetTyLeHoaHong() => 0.05; // 5% hoa hồng quản lý
        public override bool CoQuyenDuyetGiamGia() => true; // Có quyền duyệt giảm giá, chiết khấu
        public override bool CoQuyenXuatKhoChiDinh() => true; // Có quyền duyệt chỉ định lô
    }
}
