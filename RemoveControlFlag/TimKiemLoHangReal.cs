using System;
using System.Collections.Generic;

namespace RemoveControlFlag
{
    public class TimKiemLoHangReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REMOVE CONTROL FLAG ===");
            Console.WriteLine("Nghiệp vụ: Tìm mã lô nông dược trong kho để xuất hàng theo chỉ định\n");

            var dsLo = new List<string> { "LO-2026-001", "LO-2026-002", "LO-ANVIL-99", "LO-2026-004" };
            string maCanTim = "LO-ANVIL-99";

            Console.WriteLine($"Danh sách lô kho: {string.Join(", ", dsLo)}");
            Console.WriteLine($"Cần tìm lô: {maCanTim}\n");

            var before = new TimKiemLoHangBefore();
            string kqBefore = before.TimLoThuocTheoMa(dsLo, maCanTim);
            Console.WriteLine($"[Before - Dùng flag bool daTimThay]: Tìm thấy = {kqBefore}");

            var after = new TimKiemLoHangAfter();
            string kqAfter = after.TimLoThuocTheoMa(dsLo, maCanTim);
            Console.WriteLine($"[After  - Dùng return trực tiếp]   : Tìm thấy = {kqAfter}");
        }
    }
}
