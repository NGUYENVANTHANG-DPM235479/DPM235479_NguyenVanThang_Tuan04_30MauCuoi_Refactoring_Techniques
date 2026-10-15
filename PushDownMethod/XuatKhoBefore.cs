using System;
namespace PushDownMethod
{
    // TRƯỚC: Lớp cha KhachHang có hàm InTheVip(), nhưng chỉ KhachHangVip mới có thẻ
    public abstract class KhachHangBefore
    {
        public string Ten { get; set; }
        public void InTheVip() => Console.WriteLine($"In thẻ VIP cho: {Ten}");
    }

    public class KhachHangThuongBefore : KhachHangBefore { }
    public class KhachHangVipBefore : KhachHangBefore { }
}