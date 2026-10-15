using System;

namespace ReplaceConditionalWithPolymorphism
{
    // SAU REFACTOR: Thay thế câu lệnh điều kiện/switch-case bằng tính đa hình (Polymorphism).
    public abstract class PhuongPhapXuatKhoAfter
    {
        public abstract double TinhGiaXuat(double giaLoDauTien, double giaTrungBinhCong);
    }

    public class XuatKhoFIFO : PhuongPhapXuatKhoAfter
    {
        public override double TinhGiaXuat(double giaLoDauTien, double giaTrungBinhCong)
        {
            return giaLoDauTien;
        }
    }

    public class XuatKhoBinhQuanGiaQuyen : PhuongPhapXuatKhoAfter
    {
        public override double TinhGiaXuat(double giaLoDauTien, double giaTrungBinhCong)
        {
            return giaTrungBinhCong;
        }
    }
}
