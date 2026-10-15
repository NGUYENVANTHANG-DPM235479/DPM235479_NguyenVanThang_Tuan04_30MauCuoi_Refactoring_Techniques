using System;
namespace ReplaceParameterWithExplicitMethods
{
    public class XuatKhoTheoLoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: REPLACE PARAMETER WITH EXPLICIT METHODS ===");
            var before = new XuatKhoTheoLoBefore();
            var after = new XuatKhoTheoLoAfter();
            Console.WriteLine("[Before - Dùng cờ int phân loại]:");
            before.XuatKho(XuatKhoTheoLoBefore.FIFO, "LO-ANVIL-01");

            Console.WriteLine("\n[After - Dùng phương thức tường minh]:");
            after.XuatKhoTheoFIFO("LO-ANVIL-01");
            after.XuatKhoTheoChiDinh("LO-TILTSUPER-02");
        }
    }
}