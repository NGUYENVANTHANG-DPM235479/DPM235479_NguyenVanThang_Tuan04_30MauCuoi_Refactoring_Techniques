using System;
using System.Collections.Generic;
namespace ReplaceExceptionWithTest
{
    public class KiemTraTonKhoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE EXCEPTION WITH TEST ===");
            var listRong = new List<string>();
            var before = new KiemTraTonKhoBefore();
            var after = new KiemTraTonKhoAfter();
            Console.WriteLine($"[Before - Bắt Exception]: {before.LayLoDauTien(listRong)}");
            Console.WriteLine($"[After  - Dùng if test] : {after.LayLoDauTien(listRong)}");
        }
    }
}