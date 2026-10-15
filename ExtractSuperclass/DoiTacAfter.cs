using System;
namespace ExtractSuperclass
{
    // SAU: Trích xuất lớp cha DoiTacAfter chứa các thông tin chung
    public abstract class DoiTacAfter
    {
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
    }

    public class KhachHangAfter : DoiTacAfter { }
    public class NhaCungCapAfter : DoiTacAfter { }
}