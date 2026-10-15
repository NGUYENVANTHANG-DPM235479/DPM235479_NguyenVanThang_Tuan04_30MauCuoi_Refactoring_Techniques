using System;

namespace ConsolidateConditionalExpression
{
    // SAU REFACTOR: Gộp các điều kiện cùng đích đến thành một biểu thức duy nhất
    // và trích xuất thành phương thức có tên rõ ràng (Consolidate Conditional Expression).
    public class KiemTraXuatKhoAfter
    {
        public double SoLuongTonKho { get; set; }
        public DateTime NgayHetHan { get; set; }
        public bool DaKiemDinhChatLuong { get; set; }

        public KiemTraXuatKhoAfter(double tonKho, DateTime hanDung, bool kiemDinh)
        {
            SoLuongTonKho = tonKho;
            NgayHetHan = hanDung;
            DaKiemDinhChatLuong = kiemDinh;
        }

        public double TinhSoLuongChoPhepXuat(double soLuongYeuCau)
        {
            if (KhongDuDieuKienXuatKho())
                return 0;

            return Math.Min(soLuongYeuCau, SoLuongTonKho);
        }

        // Gộp các điều kiện bằng toán tử ||
        private bool KhongDuDieuKienXuatKho()
        {
            return (SoLuongTonKho <= 0)
                || (NgayHetHan < DateTime.Today)
                || (!DaKiemDinhChatLuong);
        }
    }
}
