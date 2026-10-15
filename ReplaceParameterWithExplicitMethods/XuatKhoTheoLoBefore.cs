using System;
namespace ReplaceParameterWithExplicitMethods
{
    // TRƯỚC: Dùng cờ int phuongPhap để rẽ nhánh bên trong hàm
    public class XuatKhoTheoLoBefore
    {
        public const int FIFO = 1;
        public const int CHI_DINH = 2;

        public void XuatKho(int phuongPhap, string maLo)
        {
            if (phuongPhap == FIFO)
                Console.WriteLine($"Xuất kho tự động theo ngày hết hạn (FIFO): {maLo}");
            else
                Console.WriteLine($"Xuất kho theo chỉ định người dùng: {maLo}");
        }
    }
}