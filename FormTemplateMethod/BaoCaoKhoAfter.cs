using System;
namespace FormTemplateMethod
{
    // SAU: Tạo Template Method ở lớp cha định hình khung sườn
    public abstract class BaoCaoKhoTemplate
    {
        public void TaoBaoCao()
        {
            InTieuDe();
            InNoiDung();
            InKetThuc();
        }

        private void InTieuDe() => Console.WriteLine("=== BÁO CÁO NÔNG DƯỢC AN GIANG ===");
        private void InKetThuc() => Console.WriteLine("--- KÝ TÊN THỦ KHO ---");
        protected abstract void InNoiDung();
    }

    public class BaoCaoNhapKhoAfter : BaoCaoKhoTemplate
    {
        protected override void InNoiDung() => Console.WriteLine("Chi tiết: Nhập kho 500 bao phân bón");
    }

    public class BaoCaoXuatKhoAfter : BaoCaoKhoTemplate
    {
        protected override void InNoiDung() => Console.WriteLine("Chi tiết: Xuất kho 200 chai thuốc sâu");
    }
}