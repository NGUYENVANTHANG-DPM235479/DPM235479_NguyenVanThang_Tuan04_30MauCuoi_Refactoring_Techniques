using System;
namespace RenameMethod
{
    public class DichVuNongDuocReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: RENAME METHOD ===");
            var before = new DichVuNongDuocBefore();
            var after = new DichVuNongDuocAfter();
            Console.WriteLine($"[Before - hàm Calc()]: Phí ship = {before.Calc(15, 10000):N0} đ");
            Console.WriteLine($"[After  - hàm TinhChiPhiVanChuyenNongDuoc()]: Phí ship = {after.TinhChiPhiVanChuyenNongDuoc(15, 10000):N0} đ");
        }
    }
}