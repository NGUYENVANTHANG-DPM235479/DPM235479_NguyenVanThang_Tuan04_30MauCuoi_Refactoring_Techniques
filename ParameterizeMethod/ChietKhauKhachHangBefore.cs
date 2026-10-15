using System;
namespace ParameterizeMethod
{
    // TRƯỚC: Viết nhiều hàm tính chiết khấu cho từng cấp đại lý với code giống hệt nhau
    public class ChietKhauKhachHangBefore
    {
        public double ChietKhauDaiLyCap1(double tienHang) => tienHang * 0.10;
        public double ChietKhauDaiLyCap2(double tienHang) => tienHang * 0.05;
        public double ChietKhauDaiLyCap3(double tienHang) => tienHang * 0.02;
    }
}