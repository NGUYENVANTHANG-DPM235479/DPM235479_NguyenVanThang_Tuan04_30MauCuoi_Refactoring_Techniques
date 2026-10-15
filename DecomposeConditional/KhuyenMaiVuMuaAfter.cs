using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional
{
    // =========================================================================================
    // MẪU REFACTORING: DECOMPOSE CONDITIONAL (Phân rã biểu thức điều kiện)
    // 
    // NGUYÊN TẮC:
    // "You have a complicated conditional (if-then-else) statement.
    //  Decompose the conditional into separate methods for the condition,
    //  the 'then' part, and the 'else' part."
    // 
    // CÁC BƯỚC THỰC HIỆN:
    // 1. Tách biểu thức điều kiện phức tạp thành một phương thức có tên rõ nghĩa thể hiện ý đồ (Intention-Revealing Method):
    //    -> LaTrongDotTroGiaVuDongXuan()
    // 2. Tách khối xử lý bên trong nhánh 'then' thành một phương thức độc lập:
    //    -> TinhTienTheoChinhSachTroGiaVuMua()
    // 3. Tách khối xử lý bên trong nhánh 'else' thành một phương thức độc lập:
    //    -> TinhTienTheoChinhSachNgayThuong()
    // 
    // LỢI ÍCH TRONG ĐỒ ÁN NÔNG DƯỢC AN GIANG:
    // - Code trở nên trong sáng, đọc như văn xuôi tự nhiên.
    // - Dễ dàng điều chỉnh tiêu chí mùa vụ hoặc công thức chiết khấu/phí ship mà không sợ ảnh hưởng phần khác.
    // - Tái sử dụng được các phương thức tính toán riêng biệt cho các module thống kê báo cáo.
    // =========================================================================================

    public class KhuyenMaiVuMuaAfter
    {
        public static readonly DateTime BAT_DAU_VU_DONG_XUAN = new DateTime(2026, 11, 1);
        public static readonly DateTime KET_THUC_VU_DONG_XUAN = new DateTime(2027, 2, 28);

        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public double TienHang { get; set; }
        public int SoBaoPhanBon { get; set; }
        public double PhiVanChuyen { get; set; }
        public double PhiDichVuPhu { get; set; }

        public KhuyenMaiVuMuaAfter(string maHD, DateTime ngayLap, double tienHang, int soBao, double phiShip, double phiDV)
        {
            MaHoaDon = maHD;
            NgayLap = ngayLap;
            TienHang = tienHang;
            SoBaoPhanBon = soBao;
            PhiVanChuyen = phiShip;
            PhiDichVuPhu = phiDV;
        }

        // =====================================================================================
        // PHƯƠNG THỨC SAU KHI REFACTOR: CỰC KỲ TRONG SÁNG VÀ DỄ HIỂU
        // =====================================================================================
        public double TinhTongTienThanhToan()
        {
            if (LaTrongDotTroGiaVuDongXuan())
            {
                return TinhTienTheoChinhSachTroGiaVuMua();
            }
            else
            {
                return TinhTienTheoChinhSachNgayThuong();
            }
        }

        // 1. Tách điều kiện thành hàm riêng (Condition Method)
        public bool LaTrongDotTroGiaVuDongXuan()
        {
            bool laTrongKhoangThoiGianVuMua = NgayLap >= BAT_DAU_VU_DONG_XUAN && NgayLap <= KET_THUC_VU_DONG_XUAN;
            bool datDinhMucMuaSoLuongLon = TienHang >= 15000000 || SoBaoPhanBon >= 40;

            return laTrongKhoangThoiGianVuMua && datDinhMucMuaSoLuongLon;
        }

        // 2. Tách nhánh THEN thành hàm riêng
        public double TinhTienTheoChinhSachTroGiaVuMua()
        {
            double chietKhauVuMua = TinhChietKhauVuMua();
            double phiShipHoTro = TinhPhiVanChuyenTroGia();
            double phiDichVuUuDai = PhiDichVuPhu * 0.8; // Giảm 20% phụ phí bốc xếp ngày mùa

            return (TienHang - chietKhauVuMua) + phiShipHoTro + phiDichVuUuDai;
        }

        // 3. Tách nhánh ELSE thành hàm riêng
        public double TinhTienTheoChinhSachNgayThuong()
        {
            double chietKhauThuong = TinhChietKhauNgayThuong();
            double phiShipDayDu = PhiVanChuyen; // Phí ship tính đủ 100%
            double phiDichVuChuan = PhiDichVuPhu; // Phụ phí tiêu chuẩn

            return (TienHang - chietKhauThuong) + phiShipDayDu + phiDichVuChuan;
        }

        // Các hàm con bổ trợ chi tiết (giúp code module hóa cao)
        public double TinhChietKhauVuMua() => TienHang * 0.08;
        public double TinhChietKhauNgayThuong() => (TienHang >= 10000000) ? TienHang * 0.02 : 0;
        public double TinhPhiVanChuyenTroGia() => (PhiVanChuyen > 100000) ? PhiVanChuyen * 0.5 : 0;
    }

    // =========================================================================================
    // VÍ DỤ 2 (ÁP DỤNG THÊM BÀI TOÁN XUẤT KHO NÔNG DƯỢC CẬN HẠN SỬ DỤNG - FEFO)
    // Chứng minh Decompose Conditional có thể áp dụng cho nhiều bài toán trong đồ án
    // =========================================================================================
    public class LoHangNongDuoc
    {
        public string MaLo { get; set; }
        public string TenThuocBVTV { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int SoLuongTon { get; set; }
        public double DonGiaGoc { get; set; }

        public LoHangNongDuoc(string maLo, string tenThuoc, DateTime hanDung, int tonKho, double giaGoc)
        {
            MaLo = maLo;
            TenThuocBVTV = tenThuoc;
            NgayHetHan = hanDung;
            SoLuongTon = tonKho;
            DonGiaGoc = giaGoc;
        }

        // ÁP DỤNG DECOMPOSE CONDITIONAL:
        public double TinhGiaXuatKho(DateTime ngayXuat)
        {
            if (LaLoHangCanDateCanXaKho(ngayXuat))
                return TinhDonGiaXaKhoCanDate();
            else
                return TinhDonGiaXuatKhoChuan();
        }

        // Tách điều kiện: Lô thuốc còn hạn dưới 60 ngày và tồn kho từ 50 chai/gói trở lên
        public bool LaLoHangCanDateCanXaKho(DateTime ngayXuat)
        {
            int soNgayConLai = (NgayHetHan - ngayXuat).Days;
            return soNgayConLai > 0 && soNgayConLai <= 60 && SoLuongTon >= 50;
        }

        // Tách nhánh THEN: Giảm giá xả hàng 25% để thu hồi vốn
        public double TinhDonGiaXaKhoCanDate() => DonGiaGoc * 0.75;

        // Tách nhánh ELSE: Giá xuất kho nguyên giá
        public double TinhDonGiaXuatKhoChuan() => DonGiaGoc;
    }
}
