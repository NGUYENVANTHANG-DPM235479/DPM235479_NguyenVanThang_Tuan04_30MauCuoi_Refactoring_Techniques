using System;

namespace ReplaceConditionalWithPolymorphism
{
    public class PhuongPhapXuatKhoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE CONDITIONAL WITH POLYMORPHISM ===");
            Console.WriteLine("Nghiệp vụ: Tính giá xuất kho sản phẩm (Bình quân gia quyền vs FIFO)\n");

            double giaLoDau = 120000;
            double giaBQGQ = 115000;

            // Before
            var beforeFIFO = new PhuongPhapXuatKhoBefore(PhuongPhapXuatKhoBefore.FIFO);
            var beforeBQGQ = new PhuongPhapXuatKhoBefore(PhuongPhapXuatKhoBefore.BINH_QUAN_GIA_QUYEN);
            Console.WriteLine("1. [Before - Dùng switch-case mã int]:");
            Console.WriteLine($"   + FIFO: {beforeFIFO.TinhGiaXuat(giaLoDau, giaBQGQ):N0} đ");
            Console.WriteLine($"   + Bình quân gia quyền: {beforeBQGQ.TinhGiaXuat(giaLoDau, giaBQGQ):N0} đ");

            // After
            PhuongPhapXuatKhoAfter afterFIFO = new XuatKhoFIFO();
            PhuongPhapXuatKhoAfter afterBQGQ = new XuatKhoBinhQuanGiaQuyen();
            Console.WriteLine("\n2. [After - Dùng đa hình kế thừa Class]:");
            Console.WriteLine($"   + FIFO: {afterFIFO.TinhGiaXuat(giaLoDau, giaBQGQ):N0} đ");
            Console.WriteLine($"   + Bình quân gia quyền: {afterBQGQ.TinhGiaXuat(giaLoDau, giaBQGQ):N0} đ");
        }
    }
}
