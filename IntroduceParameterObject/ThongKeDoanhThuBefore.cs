using System;
namespace IntroduceParameterObject
{
    // TRƯỚC: Nhận các tham số ngày tháng lẻ tẻ (từ ngày, đến ngày, mã nhân viên)
    public class ThongKeDoanhThuBefore
    {
        public void InBaoCao(DateTime tuNgay, DateTime denNgay, string maNhanVien)
        {
            Console.WriteLine($"Thống kê hóa đơn NV {maNhanVien} từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}");
        }
    }
}