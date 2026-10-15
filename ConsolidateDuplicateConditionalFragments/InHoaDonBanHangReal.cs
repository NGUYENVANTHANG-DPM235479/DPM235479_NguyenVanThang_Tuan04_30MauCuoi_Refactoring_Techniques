using System;

namespace ConsolidateDuplicateConditionalFragments
{
    public class InHoaDonBanHangReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: CONSOLIDATE DUPLICATE CONDITIONAL FRAGMENTS ===");
            Console.WriteLine("Nghiệp vụ: Xử lý xuất hóa đơn bán sỉ / bán lẻ thuốc nông dược\n");

            Console.WriteLine("1. Chạy với mã Before (Trùng lặp thao tác lưu CSDL & in ấn):");
            var hdBefore = new InHoaDonBanHangBefore();
            hdBefore.LapHoaDon("HD-SI-01", 10000000, laBanSi: true);

            Console.WriteLine("\n2. Chạy với mã After (Đã đưa đoạn code trùng lặp ra ngoài if-else):");
            var hdAfter = new InHoaDonBanHangAfter();
            hdAfter.LapHoaDon("HD-LE-02", 2000000, laBanSi: false);
        }
    }
}
