using System;
namespace FormTemplateMethod
{
    // TRƯỚC: 2 lớp báo cáo lặp lại cùng khung sườn (Header -> Body -> Footer)
    public class BaoCaoNhapKhoBefore
    {
        public void TaoBaoCao()
        {
            Console.WriteLine("=== BÁO CÁO NÔNG DƯỢC AN GIANG ===");
            Console.WriteLine("Chi tiết: Nhập kho 500 bao phân bón");
            Console.WriteLine("--- KÝ TÊN THỦ KHO ---");
        }
    }

    public class BaoCaoXuatKhoBefore
    {
        public void TaoBaoCao()
        {
            Console.WriteLine("=== BÁO CÁO NÔNG DƯỢC AN GIANG ===");
            Console.WriteLine("Chi tiết: Xuất kho 200 chai thuốc sâu");
            Console.WriteLine("--- KÝ TÊN THỦ KHO ---");
        }
    }
}