using System;
namespace ReplaceParameterWithMethodCall
{
    // SAU: Bỏ tham số tyLeGiamGia, phương thức tự gọi hàm LayTyLeGiamGia() nội bộ
    public class TinhGiaBanAfter
    {
        public double TinhTienHang(double giaGoc)
        {
            double tyLe = LayTyLeGiamGiaMacDinh();
            return giaGoc * (1 - tyLe);
        }

        private double LayTyLeGiamGiaMacDinh()
        {
            return 0.05; // 5% chiết khấu nông dược
        }
    }
}