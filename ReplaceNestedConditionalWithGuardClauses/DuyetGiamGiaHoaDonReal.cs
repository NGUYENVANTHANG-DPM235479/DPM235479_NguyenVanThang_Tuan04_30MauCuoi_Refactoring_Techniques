using System;

namespace ReplaceNestedConditionalWithGuardClauses
{
    public class DuyetGiamGiaHoaDonReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE NESTED CONDITIONAL WITH GUARD CLAUSES ===");
            Console.WriteLine("Nghiệp vụ: Duyệt giảm giá hóa đơn nông dược dựa trên quyền đăng nhập\n");

            double tongTien = 50000000; // Đơn 50 triệu
            var before = new DuyetGiamGiaHoaDonBefore();
            var after = new DuyetGiamGiaHoaDonAfter();

            // Trường hợp 1: Chưa đăng nhập
            Console.WriteLine("1. Nhân viên chưa đăng nhập:");
            Console.WriteLine($"   [Before]: Giảm giá = {before.TinhTienGiamGia(false, true, true, tongTien):N0} đ");
            Console.WriteLine($"   [After] : Giảm giá = {after.TinhTienGiamGia(false, true, true, tongTien):N0} đ");

            // Trường hợp 2: Quản lý đăng nhập và hóa đơn hợp lệ
            Console.WriteLine("\n2. Quản lý đã đăng nhập và hóa đơn hợp lệ:");
            Console.WriteLine($"   [Before]: Giảm giá = {before.TinhTienGiamGia(true, true, true, tongTien):N0} đ");
            Console.WriteLine($"   [After] : Giảm giá = {after.TinhTienGiamGia(true, true, true, tongTien):N0} đ");
        }
    }
}
