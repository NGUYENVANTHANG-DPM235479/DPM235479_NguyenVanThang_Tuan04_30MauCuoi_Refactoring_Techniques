using System;
using System.Collections.Generic;
namespace ReplaceInheritanceWithDelegation
{
    // TRƯỚC: PhieuXuatKho kế thừa List<string> (Is-a sai trái, làm lộ hết các hàm của List)
    public class PhieuXuatKhoBefore : List<string>
    {
        public void InPhieu() => Console.WriteLine($"Phiếu có {Count} sản phẩm");
    }
}