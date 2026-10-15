using System;
namespace ReplaceDelegationWithInheritance
{
    public class NguoiLaoDong
    {
        public string HoTen { get; set; } = "Trần Văn Nam";
    }

    // TRƯỚC: NhanVienGiaoHang chứa NguoiLaoDong và ủy quyền đơn giản từng hàm
    public class NhanVienGiaoHangBefore
    {
        private NguoiLaoDong _nguoi = new NguoiLaoDong();
        public string LayTen() => _nguoi.HoTen; // Ủy quyền rườm rà
    }
}