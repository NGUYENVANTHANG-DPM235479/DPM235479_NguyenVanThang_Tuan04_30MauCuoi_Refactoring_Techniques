using System;
namespace CollapseHierarchy
{
    public class LoThuocReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: COLLAPSE HIERARCHY ===");
            var lo = new LoThuocAfter { MaLo = "LO-AG-2026" };
            Console.WriteLine($"[Collapse Hierarchy]: Đã gộp gọn thành class duy nhất: {lo.MaLo}");
        }
    }
}