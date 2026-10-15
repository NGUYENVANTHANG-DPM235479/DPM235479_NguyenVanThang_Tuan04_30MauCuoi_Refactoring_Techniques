using System;
using System.Collections.Generic;

namespace RemoveControlFlag
{
    // TRƯỚC REFACTOR: Dùng biến cờ (control flag) như bool found, bool daTimThay
    // để kiểm soát vòng lặp, khiến logic rườm rà.
    public class TimKiemLoHangBefore
    {
        public string TimLoThuocTheoMa(List<string> danhSachLo, string maCanTim)
        {
            bool daTimThay = false; // Biến cờ điều khiển (Control flag)
            string ketQua = "";

            for (int i = 0; i < danhSachLo.Count; i++)
            {
                if (!daTimThay)
                {
                    if (danhSachLo[i].Equals(maCanTim, StringComparison.OrdinalIgnoreCase))
                    {
                        ketQua = danhSachLo[i];
                        daTimThay = true; // Gán cờ để ngắt xử lý ở lần sau
                    }
                }
            }

            return ketQua;
        }
    }
}
