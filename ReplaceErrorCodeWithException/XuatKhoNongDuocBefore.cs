using System;
namespace ReplaceErrorCodeWithException
{
    // TRƯỚC: Trả về mã lỗi số nguyên (-1, -2) khi xuất kho thất bại
    public class XuatKhoNongDuocBefore
    {
        public int TonKho { get; set; } = 10;
        public int XuatHang(int soLuong)
        {
            if (soLuong > TonKho) return -1; // Mã lỗi: Không đủ hàng
            TonKho -= soLuong;
            return 0; // Thành công
        }
    }
}