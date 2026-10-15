using System;
namespace IntroduceParameterObject
{
    public class ThongKeDoanhThuReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: INTRODUCE PARAMETER OBJECT ===");
            var tuNgay = new DateTime(2026, 1, 1);
            var denNgay = new DateTime(2026, 1, 31);
            var before = new ThongKeDoanhThuBefore();
            before.InBaoCao(tuNgay, denNgay, "NV01");

            var after = new ThongKeDoanhThuAfter();
            var tieuChi = new KhoangNgayThongKe(tuNgay, denNgay, "NV01");
            after.InBaoCao(tieuChi);
        }
    }
}