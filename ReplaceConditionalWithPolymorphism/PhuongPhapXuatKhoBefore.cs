using System;

namespace ReplaceConditionalWithPolymorphism
{
    // TRƯỚC REFACTOR: Dùng switch-case dựa trên mã loại phương pháp tính giá xuất kho
    // (Bình quân gia quyền vs Nhập trước xuất trước FIFO).
    public class PhuongPhapXuatKhoBefore
    {
        public const int FIFO = 1;
        public const int BINH_QUAN_GIA_QUYEN = 2;

        public int LoaiPhuongPhap { get; set; }

        public PhuongPhapXuatKhoBefore(int loai)
        {
            LoaiPhuongPhap = loai;
        }

        public double TinhGiaXuat(double giaLoDauTien, double giaTrungBinhCong)
        {
            switch (LoaiPhuongPhap)
            {
                case FIFO:
                    return giaLoDauTien;
                case BINH_QUAN_GIA_QUYEN:
                    return giaTrungBinhCong;
                default:
                    throw new InvalidOperationException("Phương pháp không hợp lệ");
            }
        }
    }
}
