using System;
namespace ExtractInterface
{
    // SAU: Trích xuất Interface IInHoaDon để Decouple mã nguồn
    public interface IInHoaDon
    {
        void InHoaDon(string ma);
    }

    public class HoaDonDienTuAfter : IInHoaDon
    {
        public void InHoaDon(string ma) => Console.WriteLine($"In HĐ điện tử: {ma}");
    }

    public class MayInHoaDonAfter
    {
        public void Xuat(IInHoaDon hd, string ma) => hd.InHoaDon(ma);
    }
}