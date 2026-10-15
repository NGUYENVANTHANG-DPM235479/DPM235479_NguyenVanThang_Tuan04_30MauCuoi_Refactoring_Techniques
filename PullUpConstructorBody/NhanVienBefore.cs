using System;
namespace PullUpConstructorBody
{
    // TRƯỚC: Constructor của lớp con tự gán MaNV, HoTen lặp đi lặp lại
    public abstract class NhanVienBefore
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
    }

    public class NhanVienBanHangBefore : NhanVienBefore
    {
        public double DoanhSo { get; set; }
        public NhanVienBanHangBefore(string ma, string ten, double doanhSo)
        {
            MaNV = ma;
            HoTen = ten;
            DoanhSo = doanhSo;
        }
    }
}