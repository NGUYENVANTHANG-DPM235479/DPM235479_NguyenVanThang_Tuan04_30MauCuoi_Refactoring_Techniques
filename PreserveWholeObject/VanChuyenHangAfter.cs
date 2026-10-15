using System;
namespace PreserveWholeObject
{
    // SAU: Truyền nguyên đối tượng DonHang (Preserve Whole Object)
    public class VanChuyenHangAfter
    {
        public double TinhCuocVanChuyen(DonHangNongDuoc donHang)
        {
            return (donHang.TienHang >= 10000000) ? donHang.KhoangCachKm * 5000 : donHang.KhoangCachKm * 10000;
        }
    }
}