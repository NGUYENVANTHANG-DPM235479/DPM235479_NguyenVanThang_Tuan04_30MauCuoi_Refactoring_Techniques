using System;

namespace IntroduceNullObject
{
    // SAU REFACTOR: Giới thiệu Null Object để loại bỏ việc kiểm tra != null lặp đi lặp lại.
    public interface IDichVuVanChuyen
    {
        string TenDichVu { get; }
        double PhiVanChuyen { get; }
    }

    public class DichVuVanChuyenThat : IDichVuVanChuyen
    {
        public string TenDichVu => "Giao hàng tận nơi";
        public double PhiVanChuyen => 50000;
    }

    // Null Object đóng gói hành vi mặc định khi không có dịch vụ
    public class NullDichVuVanChuyen : IDichVuVanChuyen
    {
        public string TenDichVu => "Không sử dụng dịch vụ";
        public double PhiVanChuyen => 0;
    }

    public class HoaDonAfter
    {
        public IDichVuVanChuyen DichVuShip { get; set; }

        public HoaDonAfter(IDichVuVanChuyen dichVu = null)
        {
            // Nếu không truyền, gán Null Object mặc định
            DichVuShip = dichVu ?? new NullDichVuVanChuyen();
        }

        // Không cần bất kỳ câu lệnh if (DichVuShip != null) nào
        public double TinhTongTien(double tienHang)
        {
            return tienHang + DichVuShip.PhiVanChuyen;
        }

        public string LayTenDichVu()
        {
            return DichVuShip.TenDichVu;
        }
    }
}
