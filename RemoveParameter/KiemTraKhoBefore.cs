using System;
namespace RemoveParameter
{
    // TRƯỚC: Hàm nhận tham số maVung nhưng không hề sử dụng trong thuật toán tính giá xuất kho
    public class KiemTraKhoBefore
    {
        public double TinhGiaXuatKho(double giaGoc, double heSo, string maVung)
        {
            // maVung không còn dùng nhưng vẫn phải truyền vào
            return giaGoc * heSo;
        }
    }
}