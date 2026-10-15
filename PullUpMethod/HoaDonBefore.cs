using System;
namespace PullUpMethod
{
    // TRƯỚC: Cả HoaDonBanSi và HoaDonBanLe đều tự viết phương thức TinhThueVAT() giống hệt nhau
    public abstract class HoaDonBefore { public double TienHang { get; set; } }

    public class HoaDonBanSiBefore : HoaDonBefore
    {
        public double TinhThueVAT() => TienHang * 0.1; // Trùng lặp
    }

    public class HoaDonBanLeBefore : HoaDonBefore
    {
        public double TinhThueVAT() => TienHang * 0.1; // Trùng lặp
    }
}