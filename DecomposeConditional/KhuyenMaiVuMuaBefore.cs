using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional
{
    // =========================================================================================
    // CODE SMELL: COMPLEX CONDITIONAL (Khối lệnh điều kiện phức tạp, cồng kềnh)
    // 
    // Tình trạng trước khi Refactor:
    // Nghiệp vụ: Tính tổng tiền thanh toán hóa đơn nông dược có áp dụng chương trình
    // "Trợ giá vụ Đông Xuân & Hỗ trợ vận chuyển nông dân An Giang".
    // 
    // NHƯỢC ĐIỂM:
    // 1. Biểu thức trong 'if' quá dài dòng và phức tạp (kiểm tra khoảng ngày mùa vụ, số lượng bao,
    //    tổng tiền hàng), người đọc code không thể hiểu ngay ý nghĩa nghiệp vụ nếu không đọc kỹ.
    // 2. Khối lệnh bên trong nhánh 'then' và 'else' chứa nhiều công thức tính toán chiết khấu,
    //    giảm giá và phí vận chuyển lồng ghép nhau, gây khó khăn cho việc bảo trì và kiểm thử.
    // =========================================================================================

    public class KhuyenMaiVuMuaBefore
    {
        public static readonly DateTime BAT_DAU_VU_DONG_XUAN = new DateTime(2026, 11, 1);
        public static readonly DateTime KET_THUC_VU_DONG_XUAN = new DateTime(2027, 2, 28);

        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public double TienHang { get; set; }
        public int SoBaoPhanBon { get; set; }
        public double PhiVanChuyen { get; set; }
        public double PhiDichVuPhu { get; set; }

        public KhuyenMaiVuMuaBefore(string maHD, DateTime ngayLap, double tienHang, int soBao, double phiShip, double phiDV)
        {
            MaHoaDon = maHD;
            NgayLap = ngayLap;
            TienHang = tienHang;
            SoBaoPhanBon = soBao;
            PhiVanChuyen = phiShip;
            PhiDichVuPhu = phiDV;
        }

        // PHƯƠNG THỨC CHỨA KHỐI LỆNH ĐIỀU KIỆN PHỨC TẠP
        public double TinhTongTienThanhToan()
        {
            double tongTien = 0;

            // VẤN ĐỀ: Biểu thức kiểm tra điều kiện dài và khó hiểu
            if ((NgayLap >= BAT_DAU_VU_DONG_XUAN && NgayLap <= KET_THUC_VU_DONG_XUAN) 
                && (TienHang >= 15000000 || SoBaoPhanBon >= 40))
            {
                // Nhánh THEN: Tính toán chiết khấu trợ giá mùa vụ và hỗ trợ chi phí vận chuyển
                double chietKhauVuMua = TienHang * 0.08; // Giảm 8% tiền thuốc & phân bón mùa vụ
                double phiShipHoTro = (PhiVanChuyen > 100000) ? PhiVanChuyen * 0.5 : 0; // Hỗ trợ 50% hoặc free ship
                double phiDichVuUuDai = PhiDichVuPhu * 0.8; // Giảm 20% phụ phí bốc xếp

                tongTien = (TienHang - chietKhauVuMua) + phiShipHoTro + phiDichVuUuDai;
            }
            else
            {
                // Nhánh ELSE: Tính theo chính sách ngày thường thông thường
                double chietKhauThuong = (TienHang >= 10000000) ? TienHang * 0.02 : 0; // Đơn trên 10tr mới giảm 2%
                double phiShipDayDu = PhiVanChuyen; // Phí ship tính đủ 100%
                double phiDichVuChuan = PhiDichVuPhu; // Phụ phí không giảm

                tongTien = (TienHang - chietKhauThuong) + phiShipDayDu + phiDichVuChuan;
            }

            return tongTien;
        }
    }
}
