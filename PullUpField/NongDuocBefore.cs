using System;
namespace PullUpField
{
    // TRƯỚC: Hai lớp con PhanBon và ThuocTruSau đều tự khai báo trường MaSanPham giống nhau
    public abstract class SanPhamBefore { }

    public class PhanBonBefore : SanPhamBefore
    {
        public string MaSanPham; // Trùng lặp
        public string LoaiPhanBon;
    }

    public class ThuocTruSauBefore : SanPhamBefore
    {
        public string MaSanPham; // Trùng lặp
        public string HoatChat;
    }
}