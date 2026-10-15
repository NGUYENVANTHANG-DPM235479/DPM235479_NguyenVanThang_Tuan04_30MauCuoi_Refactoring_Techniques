using System;
namespace ReplaceErrorCodeWithException
{
    // SAU: Ném ra ngoại lệ rõ ràng khi xảy ra tình huống bất thường
    public class XuatKhoNongDuocAfter
    {
        public int TonKho { get; set; } = 10;
        public void XuatHang(int soLuong)
        {
            if (soLuong > TonKho)
                throw new InvalidOperationException($"Không đủ hàng xuất kho! Yêu cầu {soLuong}, tồn kho chỉ còn {TonKho}.");
            TonKho -= soLuong;
        }
    }
}