using System;
namespace ReplaceParameterWithExplicitMethods
{
    // SAU: Thay thế bằng các phương thức tường minh, rõ ràng cho từng hành vi
    public class XuatKhoTheoLoAfter
    {
        public void XuatKhoTheoFIFO(string maLo)
        {
            Console.WriteLine($"Xuất kho tự động theo ngày hết hạn (FIFO): {maLo}");
        }

        public void XuatKhoTheoChiDinh(string maLo)
        {
            Console.WriteLine($"Xuất kho theo chỉ định người dùng: {maLo}");
        }
    }
}