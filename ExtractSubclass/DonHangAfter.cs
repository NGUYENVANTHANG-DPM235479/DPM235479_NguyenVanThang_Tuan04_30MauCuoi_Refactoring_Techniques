using System;
namespace ExtractSubclass
{
    // SAU: Trích xuất lớp con DonHangDuongThuy cho tính năng phụ phí ghe xuồng miền Tây
    public class DonHangAfter
    {
        public double TienHang { get; set; }
        public virtual double TinhTongTien() => TienHang;
    }

    public class DonHangDuongThuyAfter : DonHangAfter
    {
        public double PhiGheXuong { get; set; }
        public override double TinhTongTien() => TienHang + PhiGheXuong;
    }
}