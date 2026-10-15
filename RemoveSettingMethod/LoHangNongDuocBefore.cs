using System;
namespace RemoveSettingMethod
{
    // TRƯỚC: Thuộc tính MaLo có setter công khai, dễ bị ghi đè sai lệch dữ liệu sau khi nhập kho
    public class LoHangNongDuocBefore
    {
        public string MaLo { get; set; }
        public LoHangNongDuocBefore(string maLo)
        {
            MaLo = maLo;
        }
    }
}