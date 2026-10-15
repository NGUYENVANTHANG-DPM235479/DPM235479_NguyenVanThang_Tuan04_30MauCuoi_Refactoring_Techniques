using System;
using System.Diagnostics;

namespace IntroduceAssertion
{
    // SAU REFACTOR: Dùng Debug.Assert để nêu rõ các giả định tiên quyết (Preconditions),
    // giúp bắt lỗi ngay lập tức trong quá trình phát triển và kiểm thử.
    public class ChietKhauHoaDonAfter
    {
        public double TinhTienSauChietKhau(double tienHang, double tyLeChietKhau)
        {
            // Introduce Assertion: Khẳng định điều kiện bắt buộc phải đúng
            Debug.Assert(tienHang >= 0, "Tiền hàng nông dược không được phép là số âm!");
            Debug.Assert(tyLeChietKhau >= 0 && tyLeChietKhau <= 1.0, "Tỷ lệ chiết khấu phải nằm trong đoạn [0, 1]!");

            // Xử lý an toàn trong runtime
            if (tienHang < 0 || tyLeChietKhau < 0 || tyLeChietKhau > 1.0)
            {
                throw new ArgumentException("Dữ liệu chiết khấu hoặc tiền hàng không hợp lệ!");
            }

            return tienHang - (tienHang * tyLeChietKhau);
        }
    }
}
