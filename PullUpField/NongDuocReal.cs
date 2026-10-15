using System;
namespace PullUpField
{
    public class NongDuocReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: PULL UP FIELD ===");
            var pb = new PhanBonAfter { MaSanPham = "PB01", LoaiPhanBon = "NPK" };
            var thuoc = new ThuocTruSauAfter { MaSanPham = "TS01", HoatChat = "Abamectin" };
            Console.WriteLine($"[Pull Up Field]: Sản phẩm {pb.MaSanPham} ({pb.LoaiPhanBon}) và {thuoc.MaSanPham} ({thuoc.HoatChat})");
        }
    }
}