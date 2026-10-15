using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeStateStrategy
{
    public abstract class LoaiDonHangState
    {
        public const int BAN_LE = 0;
        public const int BAN_SI = 1;
        public const int DAI_LY_CAP_1 = 2;

        public abstract int GetTypeCode();
        public abstract string TenLoaiDon { get; }
        public abstract double TinhChietKhau(double tienHang);
        public abstract double TinhPhiVanChuyen();

        // Static Factory Method: Nơi duy nhất chuyển đổi từ mã số sang đối tượng State
        public static LoaiDonHangState TaoMoi(int code)
        {
            switch (code)
            {
                case BAN_LE:
                    return new DonHangBanLe();
                case BAN_SI:
                    return new DonHangBanSi();
                case DAI_LY_CAP_1:
                    return new DonHangDaiLyCap1();
                default:
                    throw new ArgumentException("Mã loại đơn hàng không hợp lệ!");
            }
        }
    }

    // 2. Các lớp con cụ thể (Subclasses của State/Strategy)
    public class DonHangBanLe : LoaiDonHangState
    {
        public override int GetTypeCode() => BAN_LE;
        public override string TenLoaiDon => "Bán lẻ Nông dược";
        public override double TinhChietKhau(double tienHang) => 0;
        public override double TinhPhiVanChuyen() => 30000;
    }

    public class DonHangBanSi : LoaiDonHangState
    {
        public override int GetTypeCode() => BAN_SI;
        public override string TenLoaiDon => "Bán sỉ Nông dược";
        public override double TinhChietKhau(double tienHang) => tienHang * 0.05;
        public override double TinhPhiVanChuyen() => 15000;
    }

    public class DonHangDaiLyCap1 : LoaiDonHangState
    {
        public override int GetTypeCode() => DAI_LY_CAP_1;
        public override string TenLoaiDon => "Đại lý Nông dược Cấp 1";
        public override double TinhChietKhau(double tienHang) => tienHang * 0.12;
        public override double TinhPhiVanChuyen() => 0;
    }

    // 3. Lớp Quản lý đơn hàng đã được làm sạch
    public class QuanLyDonHangAfter
    {
        public string MaHoaDon { get; set; }
        public double TienHang { get; set; }
        public double PhiDichVuPhu { get; set; }

        // Biến Type Code kiểu int đã được thay bằng đối tượng State
        private LoaiDonHangState _state;

        public QuanLyDonHangAfter(string maHoaDon, double tienHang, double phiDichVuPhu, int loaiDonHangCode)
        {
            MaHoaDon = maHoaDon;
            TienHang = tienHang;
            PhiDichVuPhu = phiDichVuPhu;
            SetLoaiDonHang(loaiDonHangCode);
        }

        // Getter và Setter đóng gói trường phân loại
        public int GetLoaiDonHang() => _state.GetTypeCode();
        public string GetTenLoaiDon() => _state.TenLoaiDon;

        public void SetLoaiDonHang(int code)
        {
            _state = LoaiDonHangState.TaoMoi(code);
        }

        // Ủy quyền (Delegate) hành vi cho đối tượng State - Không còn switch-case!
        public double TinhChietKhau() => _state.TinhChietKhau(TienHang);
        public double TinhPhiVanChuyen() => _state.TinhPhiVanChuyen();

        public double TinhTongThanhToan()
        {
            return TienHang - TinhChietKhau() + TinhPhiVanChuyen() + PhiDichVuPhu;
        }
    }
}
