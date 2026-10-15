using System;
namespace PullUpField
{
    // SAU: Kéo trường MaSanPham lên lớp cha SanPhamAfter (Pull Up Field)
    public abstract class SanPhamAfter
    {
        public string MaSanPham; // Được kéo lên lớp cha dùng chung
    }

    public class PhanBonAfter : SanPhamAfter
    {
        public string LoaiPhanBon;
    }

    public class ThuocTruSauAfter : SanPhamAfter
    {
        public string HoatChat;
    }
}