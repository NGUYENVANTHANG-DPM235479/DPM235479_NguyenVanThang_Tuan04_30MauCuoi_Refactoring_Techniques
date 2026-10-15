using System;
namespace CollapseHierarchy
{
    // TRƯỚC: Phân cấp thừa thãi - Lớp con LoThuocDacBiet không có thêm hành vi nào đáng kể
    public class LoThuocBefore
    {
        public string MaLo { get; set; }
    }

    public class LoThuocDacBietBefore : LoThuocBefore
    {
        // Hoàn toàn không có thêm thuộc tính/hành vi mới
    }
}