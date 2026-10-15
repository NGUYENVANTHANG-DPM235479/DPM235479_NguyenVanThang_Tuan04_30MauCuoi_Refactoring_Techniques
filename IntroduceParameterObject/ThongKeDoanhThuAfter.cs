using System;
namespace IntroduceParameterObject
{
    // SAU: Gom các tham số liên quan thành đối tượng KhoangNgayThongKe
    public class KhoangNgayThongKe
    {
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string MaNhanVien { get; set; }

        public KhoangNgayThongKe(DateTime tuNgay, DateTime denNgay, string maNV)
        {
            TuNgay = tuNgay;
            DenNgay = denNgay;
            MaNhanVien = maNV;
        }
    }

    public class ThongKeDoanhThuAfter
    {
        public void InBaoCao(KhoangNgayThongKe tieuChi)
        {
            Console.WriteLine($"Thống kê hóa đơn NV {tieuChi.MaNhanVien} từ {tieuChi.TuNgay:dd/MM/yyyy} đến {tieuChi.DenNgay:dd/MM/yyyy}");
        }
    }
}