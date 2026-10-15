using System;
namespace SeparateQueryFromModifier
{
    // TRƯỚC: Hàm vừa kiểm tra lô thuốc hết hạn (Query) vừa tự động sửa đổi trạng thái kho (Modifier)
    public class QuanLyKhoBefore
    {
        public int SoLuongTon { get; set; } = 100;
        public bool KiemTraVaXuatKho(int soLuong)
        {
            if (SoLuongTon >= soLuong)
            {
                SoLuongTon -= soLuong; // Tác dụng phụ (Side effect) làm thay đổi dữ liệu
                return true;
            }
            return false;
        }
    }
}