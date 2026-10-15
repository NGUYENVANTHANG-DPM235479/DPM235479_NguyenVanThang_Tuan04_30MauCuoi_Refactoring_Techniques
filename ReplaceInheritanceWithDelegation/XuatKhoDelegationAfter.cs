using System;
using System.Collections.Generic;
namespace ReplaceInheritanceWithDelegation
{
    // SAU: Thay kế thừa bằng Ủy quyền (Delegation) - chứa List bên trong
    public class PhieuXuatKhoAfter
    {
        private readonly List<string> _danhSachSP = new List<string>();

        public void ThemSanPham(string sp) => _danhSachSP.Add(sp);
        public void InPhieu() => Console.WriteLine($"Phiếu có {_danhSachSP.Count} sản phẩm");
    }
}