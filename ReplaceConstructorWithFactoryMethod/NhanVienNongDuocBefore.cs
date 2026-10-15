using System;
namespace ReplaceConstructorWithFactoryMethod
{
    // TRƯỚC: Dùng constructor trực tiếp với cờ int loaiNV khó đọc
    public class NhanVienNongDuocBefore
    {
        public string ChucVu { get; set; }
        public NhanVienNongDuocBefore(int loaiNV)
        {
            if (loaiNV == 1) ChucVu = "Nhân viên Bán hàng";
            else ChucVu = "Thủ kho Nông dược";
        }
    }
}