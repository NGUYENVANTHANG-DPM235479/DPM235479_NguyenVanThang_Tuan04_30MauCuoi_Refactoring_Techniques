using System;
namespace PullUpMethod
{
    // SAU: Kéo phương thức TinhThueVAT() lên lớp cha HoaDonAfter (Pull Up Method)
    public abstract class HoaDonAfter
    {
        public double TienHang { get; set; }
        public double TinhThueVAT() => TienHang * 0.1; // Dùng chung ở lớp cha
    }

    public class HoaDonBanSiAfter : HoaDonAfter { }
    public class HoaDonBanLeAfter : HoaDonAfter { }
}