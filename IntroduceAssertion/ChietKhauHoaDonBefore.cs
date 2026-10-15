using System;

namespace IntroduceAssertion
{
    // TRƯỚC REFACTOR: Giả định ngầm định tỷ lệ chiết khấu luôn trong khoảng [0, 1]
    // và tiền hàng không âm mà không có Assertion kiểm tra, dẫn đến lỗi tính sai tiền âm hoặc giảm giá > 100%.
    public class ChietKhauHoaDonBefore
    {
        public double TinhTienSauChietKhau(double tienHang, double tyLeChietKhau)
        {
            // Không kiểm tra ràng buộc, hoàn toàn dựa vào niềm tin (implicit assumption)
            return tienHang - (tienHang * tyLeChietKhau);
        }
    }
}
