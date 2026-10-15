using System;
namespace ReplaceDelegationWithInheritance
{
    public class NhanVienVanChuyenReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE DELEGATION WITH INHERITANCE ===");
            var nv = new NhanVienGiaoHangAfter();
            Console.WriteLine($"[Replace Delegation with Inheritance]: {nv.HoTen} (Phụ cấp: {nv.PhuCapXangXe})");
        }
    }
}