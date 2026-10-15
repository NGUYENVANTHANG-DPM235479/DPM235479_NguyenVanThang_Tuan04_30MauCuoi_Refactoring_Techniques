using System;
namespace PushDownField
{
    // TRƯỚC: Lớp cha NongDuoc khai báo NhietDoKhoLanh, nhưng chỉ ThuocSinhHoc mới cần
    public abstract class NongDuocBefore
    {
        public string Ten;
        public double NhietDoKhoLanh; // Phân bón vô cơ không cần trường này
    }

    public class PhanNPKBefore : NongDuocBefore { }
    public class ThuocSinhHocBefore : NongDuocBefore { }
}