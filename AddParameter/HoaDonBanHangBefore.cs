using System;
namespace AddParameter
{
    // TRƯỚC: Hàm lập hóa đơn cũ chỉ có tiền hàng, không cho phép nhập chiết khấu giảm giá
    public class HoaDonBanHangBefore
    {
        public double TinhTongTien(double tienHang)
        {
            return tienHang;
        }
    }
}