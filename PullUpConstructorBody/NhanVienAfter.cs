using System;
namespace PullUpConstructorBody
{
    // SAU: Kéo phần gán MaNV, HoTen lên constructor của lớp cha và gọi base(ma, ten)
    public abstract class NhanVienAfter
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        protected NhanVienAfter(string ma, string ten)
        {
            MaNV = ma;
            HoTen = ten;
        }
    }

    public class NhanVienBanHangAfter : NhanVienAfter
    {
        public double DoanhSo { get; set; }
        public NhanVienBanHangAfter(string ma, string ten, double doanhSo) : base(ma, ten)
        {
            DoanhSo = doanhSo;
        }
    }
}