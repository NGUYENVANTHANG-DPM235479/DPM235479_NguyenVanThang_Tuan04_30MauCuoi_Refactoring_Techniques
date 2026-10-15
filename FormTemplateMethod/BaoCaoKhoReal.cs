using System;
namespace FormTemplateMethod
{
    public class BaoCaoKhoReal
    {
        public static void ChayDemo()
        {
            Console.WriteLine("=== MẪU: FORM TEMPLATE METHOD ===");
            BaoCaoKhoTemplate bc = new BaoCaoXuatKhoAfter();
            bc.TaoBaoCao();
        }
    }
}