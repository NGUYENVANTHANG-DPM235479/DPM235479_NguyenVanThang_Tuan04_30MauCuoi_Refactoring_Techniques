using System;

namespace IntroduceAssertion
{
    public class ChietKhauHoaDonReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: INTRODUCE ASSERTION ===");
            Console.WriteLine("Nghiệp vụ: Kiểm tra tính hợp lệ của chiết khấu hóa đơn bán hàng nông dược\n");

            var after = new ChietKhauHoaDonAfter();

            // Trường hợp 1: Dữ liệu hợp lệ (chiết khấu 10%)
            double tienHang = 10000000;
            double chietKhauHopLe = 0.10;
            Console.WriteLine("1. Tính chiết khấu hợp lệ (10% cho đơn 10 triệu):");
            double thanhToan = after.TinhTienSauChietKhau(tienHang, chietKhauHopLe);
            Console.WriteLine($"   -> Số tiền sau chiết khấu: {thanhToan:N0} VNĐ");

            // Trường hợp 2: Thử kiểm tra dữ liệu vi phạm assertion (chiết khấu 150%)
            Console.WriteLine("\n2. Thử nghiệm nhập sai tỷ lệ chiết khấu (1.5 = 150%):");
            try
            {
                after.TinhTienSauChietKhau(tienHang, 1.5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   ✔ Assertion & Validation đã phát hiện: {ex.Message}");
            }
        }
    }
}
