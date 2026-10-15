using System;
namespace PushDownField
{
    // SAU: Đẩy trường NhietDoKhoLanh xuống đúng lớp con cần nó (Push Down Field)
    public abstract class NongDuocAfter
    {
        public string Ten;
    }

    public class PhanNPKAfter : NongDuocAfter { }

    public class ThuocSinhHocAfter : NongDuocAfter
    {
        public double NhietDoKhoLanh; // Đẩy xuống lớp con
    }
}