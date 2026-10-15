using System;

namespace ConsolidateConditionalExpression
{
    public class KiemTraXuatKhoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: CONSOLIDATE CONDITIONAL EXPRESSION ===");
            Console.WriteLine("Nghiệp vụ: Kiểm tra lô phân bón / thuốc BVTV có đủ điều kiện xuất kho\n");

            // Trường hợp 1: Lô thuốc quá hạn
            DateTime ngayHetHan = DateTime.Today.AddDays(-5);
            var loCu = new KiemTraXuatKhoBefore(tonKho: 100, hanDung: ngayHetHan, kiemDinh: true);
            var loMoi = new KiemTraXuatKhoAfter(tonKho: 100, hanDung: ngayHetHan, kiemDinh: true);

            Console.WriteLine("1. Thử xuất kho lô thuốc HẾT HẠN (Yêu cầu 50 chai):");
            Console.WriteLine($"   [Before]: Cho phép xuất = {loCu.TinhSoLuongChoPhepXuat(50)} chai");
            Console.WriteLine($"   [After] : Cho phép xuất = {loMoi.TinhSoLuongChoPhepXuat(50)} chai");

            // Trường hợp 2: Lô hàng đạt chuẩn
            DateTime hanHopLe = DateTime.Today.AddMonths(6);
            var loDatChuan = new KiemTraXuatKhoAfter(tonKho: 200, hanDung: hanHopLe, kiemDinh: true);
            Console.WriteLine("\n2. Thử xuất kho lô hàng ĐẠT CHUẨN (Yêu cầu 50 chai):");
            Console.WriteLine($"   [After] : Cho phép xuất = {loDatChuan.TinhSoLuongChoPhepXuat(50)} chai");
        }
    }
}
