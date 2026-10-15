using System;

namespace ReplaceDelegationWithInheritance
{
    // SAU: Bản chất NhanVienGiaoHang đúng là một NguoiLaoDong -> Kế thừa trực tiếp NguoiLaoDong
    public class NhanVienGiaoHangAfter : NguoiLaoDong
    {
        public string PhuCapXangXe { get; set; } = "500,000 đ";
    }
}