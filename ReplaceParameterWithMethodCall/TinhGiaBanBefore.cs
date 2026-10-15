using System;
namespace ReplaceParameterWithMethodCall
{
    // TRƯỚC: Người gọi phải tính sẵn tỷ lệ giảm giá rồi truyền vào
    public class TinhGiaBanBefore
    {
        public double TinhTienHang(double giaGoc, double tyLeGiamGia)
        {
            return giaGoc * (1 - tyLeGiamGia);
        }
    }
}