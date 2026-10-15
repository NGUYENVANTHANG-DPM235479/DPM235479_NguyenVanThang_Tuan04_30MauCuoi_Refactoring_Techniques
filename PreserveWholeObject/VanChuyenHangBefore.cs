using System;
namespace PreserveWholeObject
{
    public class DonHangNongDuoc
    {
        public double TienHang { get; set; } = 12000000;
        public double KhoangCachKm { get; set; } = 25;
    }

    // TRƯỚC: Truyền lẻ tẻ từng thuộc tính của đối tượng DonHang
    public class VanChuyenHangBefore
    {
        public double TinhCuocVanChuyen(double tienHang, double soKm)
        {
            return (tienHang >= 10000000) ? soKm * 5000 : soKm * 10000;
        }
    }
}