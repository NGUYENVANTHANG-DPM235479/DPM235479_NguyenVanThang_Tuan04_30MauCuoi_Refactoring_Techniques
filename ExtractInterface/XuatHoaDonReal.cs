using System;
namespace ExtractInterface
{
    public class XuatHoaDonReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: EXTRACT INTERFACE ===");
            IInHoaDon hd = new HoaDonDienTuAfter();
            var mayIn = new MayInHoaDonAfter();
            mayIn.Xuat(hd, "HD-AG-999");
        }
    }
}