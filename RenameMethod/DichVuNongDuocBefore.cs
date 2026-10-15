using System;
namespace RenameMethod
{
    // TRƯỚC: Tên hàm Calc() viết tắt, mơ hồ, không rõ đang tính phí dịch vụ phụ nào
    public class DichVuNongDuocBefore
    {
        public double Calc(double soKm, double donGia)
        {
            return soKm * donGia;
        }
    }
}