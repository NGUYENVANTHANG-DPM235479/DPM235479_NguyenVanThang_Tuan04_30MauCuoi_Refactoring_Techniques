using System;
using System.Collections.Generic;

namespace RemoveControlFlag
{
    // SAU REFACTOR: Loại bỏ biến cờ bằng lệnh return trực tiếp (hoặc break) ngay khi tìm thấy.
    public class TimKiemLoHangAfter
    {
        public string TimLoThuocTheoMa(List<string> danhSachLo, string maCanTim)
        {
            foreach (var lo in danhSachLo)
            {
                if (lo.Equals(maCanTim, StringComparison.OrdinalIgnoreCase))
                {
                    return lo; // Thoát ngay lập tức, không cần biến cờ điều khiển
                }
            }

            return string.Empty;
        }
    }
}
