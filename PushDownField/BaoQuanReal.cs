using System;
namespace PushDownField
{
    public class BaoQuanReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: PUSH DOWN FIELD ===");
            var thuoc = new ThuocSinhHocAfter { Ten = "Nấm đối kháng Trichoderma", NhietDoKhoLanh = 4.5 };
            Console.WriteLine($"[Push Down Field]: {thuoc.Ten} bảo quản ở {thuoc.NhietDoKhoLanh}°C");
        }
    }
}