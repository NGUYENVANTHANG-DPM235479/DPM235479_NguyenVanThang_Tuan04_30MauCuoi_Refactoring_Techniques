using System;
using System.Collections.Generic;
namespace ReplaceExceptionWithTest
{
    // TRƯỚC: Lạm dụng try-catch để kiểm tra điều kiện thông thường
    public class KiemTraTonKhoBefore
    {
        public string LayLoDauTien(List<string> danhSachLo)
        {
            try
            {
                return danhSachLo[0]; // Có thể ném ArgumentOutOfRangeException nếu rỗng
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Kho rỗng";
            }
        }
    }
}