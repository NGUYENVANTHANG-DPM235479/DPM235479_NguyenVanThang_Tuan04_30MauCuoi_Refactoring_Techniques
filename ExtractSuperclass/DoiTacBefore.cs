using System;
namespace ExtractSuperclass
{
    // TRƯỚC: KhachHang và NhaCungCap là 2 lớp độc lập nhưng có chung các trường liên lạc
    public class KhachHangBefore
    {
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
    }

    public class NhaCungCapBefore
    {
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
    }
}