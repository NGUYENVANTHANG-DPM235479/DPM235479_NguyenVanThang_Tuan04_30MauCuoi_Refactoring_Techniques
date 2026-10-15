using System;

namespace IntroduceNullObject
{
    // TRƯỚC REFACTOR: Phải liên tục kiểm tra null (dichVu != null) trước khi tính phí vận chuyển / dịch vụ phụ.
    public class DichVuVanChuyenGiaoHang
    {
        public string TenDichVu { get; set; } = "Giao hàng tận nơi";
        public double PhiVanChuyen { get; set; } = 50000;
    }

    public class HoaDonBefore
    {
        public DichVuVanChuyenGiaoHang DichVuShip { get; set; }

        public double TinhTongTien(double tienHang)
        {
            double phiShip = 0;
            // Phải kiểm tra null khắp nơi
            if (DichVuShip != null)
            {
                phiShip = DichVuShip.PhiVanChuyen;
            }
            return tienHang + phiShip;
        }

        public string LayTenDichVu()
        {
            if (DichVuShip != null)
                return DichVuShip.TenDichVu;
            return "Không sử dụng dịch vụ";
        }
    }
}
