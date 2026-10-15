using System;
namespace ExtractSubclass
{
    // TRƯỚC: Lớp DonHang ôm đồm cả tính năng của đơn hàng có chi phí vận chuyển đường thủy/ghe xuồng
    public class DonHangBefore
    {
        public double TienHang { get; set; }
        public bool CoVanChuyenDuongThuy { get; set; }
        public double PhiGheXuong { get; set; }

        public double TinhTongTien()
        {
            return CoVanChuyenDuongThuy ? TienHang + PhiGheXuong : TienHang;
        }
    }
}