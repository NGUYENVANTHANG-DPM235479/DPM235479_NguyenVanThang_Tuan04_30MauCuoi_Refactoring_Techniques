using System;
namespace ExtractInterface
{
    // TRƯỚC: Client phụ thuộc trực tiếp vào lớp cụ thể HoaDonDienTu
    public class HoaDonDienTuBefore
    {
        public void InHoaDon(string ma) => Console.WriteLine($"In HĐ điện tử: {ma}");
    }

    public class MayInHoaDonBefore
    {
        public void Xuat(HoaDonDienTuBefore hd, string ma) => hd.InHoaDon(ma);
    }
}