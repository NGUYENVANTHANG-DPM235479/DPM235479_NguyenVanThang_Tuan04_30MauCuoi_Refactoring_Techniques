using System;
namespace ReplaceConstructorWithFactoryMethod
{
    // SAU: Thay bằng Static Factory Method có tên rõ ràng
    public class NhanVienNongDuocAfter
    {
        public string ChucVu { get; private set; }
        private NhanVienNongDuocAfter(string chucVu) => ChucVu = chucVu;

        public static NhanVienNongDuocAfter TaoNhanVienBanHang()
            => new NhanVienNongDuocAfter("Nhân viên Bán hàng");

        public static NhanVienNongDuocAfter TaoThuKho()
            => new NhanVienNongDuocAfter("Thủ kho Nông dược");
    }
}