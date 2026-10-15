using System;
using System.Collections.Generic;
namespace ReplaceExceptionWithTest
{
    // SAU: Dùng câu lệnh kiểm tra điều kiện (if) thay vì bắt ngoại lệ
    public class KiemTraTonKhoAfter
    {
        public string LayLoDauTien(List<string> danhSachLo)
        {
            if (danhSachLo == null || danhSachLo.Count == 0)
                return "Kho rỗng";
            return danhSachLo[0];
        }
    }
}