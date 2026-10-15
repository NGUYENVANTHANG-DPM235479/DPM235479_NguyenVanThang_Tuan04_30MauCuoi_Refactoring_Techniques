using System;
namespace RemoveSettingMethod
{
    // SAU: Bỏ setter, chỉ gán giá trị một lần duy nhất qua constructor (Bất biến - Immutable)
    public class LoHangNongDuocAfter
    {
        public string MaLo { get; }
        public LoHangNongDuocAfter(string maLo)
        {
            MaLo = maLo;
        }
    }
}