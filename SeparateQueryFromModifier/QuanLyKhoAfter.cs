using System;
namespace SeparateQueryFromModifier
{
    // SAU: Tách riêng hàm truy vấn (Query) và hàm thay đổi trạng thái (Modifier)
    public class QuanLyKhoAfter
    {
        public int SoLuongTon { get; set; } = 100;

        // Query: Chỉ kiểm tra, không gây tác dụng phụ
        public bool DuHangDeXuat(int soLuong)
        {
            return SoLuongTon >= soLuong;
        }

        // Modifier: Thực hiện thay đổi trạng thái
        public void TruTonKho(int soLuong)
        {
            SoLuongTon -= soLuong;
        }
    }
}