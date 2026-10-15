using System;
namespace ReplaceInheritanceWithDelegation
{
    public class XuatKhoDelegationReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE INHERITANCE WITH DELEGATION ===");
            var phieu = new PhieuXuatKhoAfter();
            phieu.ThemSanPham("Phân bón Ure");
            phieu.ThemSanPham("Thuốc trừ cỏ");
            phieu.InPhieu();
        }
    }
}