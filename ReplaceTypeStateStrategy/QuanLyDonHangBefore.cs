using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeStateStrategy
{
    public class QuanLyDonHangBefore
    {
        // LỖI MÙI CODE (Code Smell): Dùng Type Code (số nguyên) để phân loại đơn hàng
        public const int BAN_LE = 0;
        public const int BAN_SI = 1;
        public const int DAI_LY_CAP_1 = 2;

        public string MaHoaDon { get; set; }
        public double TienHang { get; set; }
        public double PhiDichVuPhu { get; set; }

        // Trường lưu Type Code (có thể bị thay đổi khi khách mua thêm hàng tại quầy)
        public int LoaiDonHang;

        public QuanLyDonHangBefore(string maHoaDon, double tienHang, double phiDichVuPhu, int loaiDonHang)
        {
            MaHoaDon = maHoaDon;
            TienHang = tienHang;
            PhiDichVuPhu = phiDichVuPhu;
            LoaiDonHang = loaiDonHang;
        }

        // VẤN ĐỀ: Câu lệnh switch-case phụ thuộc vào Type Code xuất hiện ở khắp nơi
        public double TinhChietKhau()
        {
            switch (LoaiDonHang)
            {
                case BAN_LE:
                    return 0; // Bán lẻ không chiết khấu
                case BAN_SI:
                    return TienHang * 0.05; // Bán sỉ giảm 5%
                case DAI_LY_CAP_1:
                    return TienHang * 0.12; // Đại lý cấp 1 giảm 12%
                default:
                    throw new ArgumentException("Mã loại đơn hàng không hợp lệ!");
            }
        }

        public double TinhPhiVanChuyen()
        {
            switch (LoaiDonHang)
            {
                case BAN_LE:
                    return 30000; // Phí ship cố định 30k
                case BAN_SI:
                    return 15000; // Hỗ trợ 50% phí ship
                case DAI_LY_CAP_1:
                    return 0;     // Miễn phí vận chuyển cho đại lý
                default:
                    throw new ArgumentException("Mã loại đơn hàng không hợp lệ!");
            }
        }

        public double TinhTongThanhToan()
        {
            return TienHang - TinhChietKhau() + TinhPhiVanChuyen() + PhiDichVuPhu;
        }
    }
}
