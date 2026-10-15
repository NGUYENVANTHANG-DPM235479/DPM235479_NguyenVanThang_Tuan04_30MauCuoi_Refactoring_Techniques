using System;

namespace ConsolidateConditionalExpression
{
    // TRƯỚC REFACTOR: Nhiều câu lệnh if rời rạc kiểm tra các điều kiện khác nhau
    // nhưng đều dẫn đến cùng một kết quả (không đủ điều kiện xuất kho nông dược).
    public class KiemTraXuatKhoBefore
    {
        public double SoLuongTonKho { get; set; }
        public DateTime NgayHetHan { get; set; }
        public bool DaKiemDinhChatLuong { get; set; }

        public KiemTraXuatKhoBefore(double tonKho, DateTime hanDung, bool kiemDinh)
        {
            SoLuongTonKho = tonKho;
            NgayHetHan = hanDung;
            DaKiemDinhChatLuong = kiemDinh;
        }

        public double TinhSoLuongChoPhepXuat(double soLuongYeuCau)
        {
            if (SoLuongTonKho <= 0) return 0;
            if (NgayHetHan < DateTime.Today) return 0;
            if (!DaKiemDinhChatLuong) return 0;

            return Math.Min(soLuongYeuCau, SoLuongTonKho);
        }
    }
}
