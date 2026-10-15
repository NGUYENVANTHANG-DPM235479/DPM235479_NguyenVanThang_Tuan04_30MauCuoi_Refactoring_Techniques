using System;
namespace PushDownMethod
{
    // SAU: Đẩy phương thức InTheVip() xuống lớp con KhachHangVipAfter (Push Down Method)
    public abstract class KhachHangAfter
    {
        public string Ten { get; set; }
    }

    public class KhachHangThuongAfter : KhachHangAfter { }

    public class KhachHangVipAfter : KhachHangAfter
    {
        public void InTheVip() => Console.WriteLine($"In thẻ VIP cho: {Ten}");
    }
}