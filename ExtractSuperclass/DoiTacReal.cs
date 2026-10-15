using System;
namespace ExtractSuperclass
{
    public class DoiTacReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: EXTRACT SUPERCLASS ===");
            var kh = new KhachHangAfter { Ten = "Hợp tác xã Lúa Vàng", SoDienThoai = "0912345678" };
            var ncc = new NhaCungCapAfter { Ten = "Tập đoàn Lộc Trời", SoDienThoai = "02963888999" };
            Console.WriteLine($"[Extract Superclass]: Đối tác {kh.Ten} & {ncc.Ten}");
        }
    }
}