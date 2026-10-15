using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields
{
    // =========================================================================================
    // VÍ DỤ 2 VỀ KHẢ NĂNG ÁP DỤNG NHIỀU BÀI TOÁN KHÁC TRONG ĐỒ ÁN:
    // NGHIỆP VỤ: CẤU HÌNH CÁC DỊCH VỤ PHÁT SINH & PHÍ VẬN CHUYỂN TRÊN HÓA ĐƠN
    // (Đề tài yêu cầu: "Khi lập hóa đơn bán hàng cho phép nhập các dịch vụ phát sinh và chi phí vận chuyển")
    // =========================================================================================

    #region 1. TRƯỚC REFACTOR (BEFORE): Mỗi loại dịch vụ phụ phí là 1 subclass rỗng tuếch
    public abstract class DichVuPhatSinhBefore
    {
        public abstract string GetTenDichVu();
        public abstract string GetDonViTinh();
        public abstract double GetDonGiaDinhMuc();
        public abstract bool CoChiuThueVAT();

        public double TinhThanhTien(double soLuong)
        {
            double tien = soLuong * GetDonGiaDinhMuc();
            return CoChiuThueVAT() ? tien * 1.1 : tien;
        }
    }

    public class DichVuVanChuyenBefore : DichVuPhatSinhBefore
    {
        public override string GetTenDichVu() => "Phí vận chuyển nông dược tận nơi";
        public override string GetDonViTinh() => "Chuyến";
        public override double GetDonGiaDinhMuc() => 50000;
        public override bool CoChiuThueVAT() => true;
    }

    public class DichVuBocXepBefore : DichVuPhatSinhBefore
    {
        public override string GetTenDichVu() => "Phí bốc xếp phân bón tại kho";
        public override string GetDonViTinh() => "Bao";
        public override double GetDonGiaDinhMuc() => 5000;
        public override bool CoChiuThueVAT() => false;
    }

    public class DichVuBaoQuanThuocBefore : DichVuPhatSinhBefore
    {
        public override string GetTenDichVu() => "Phí bảo quản kho lạnh thuốc BVTV";
        public override string GetDonViTinh() => "Ngày";
        public override double GetDonGiaDinhMuc() => 20000;
        public override bool CoChiuThueVAT() => true;
    }
    #endregion

    #region 2. SAU REFACTOR (AFTER): Áp dụng Replace Subclass with Fields
    // Toàn bộ các subclasses được thay thế bằng các fields và Static Factory Methods
    public class DichVuPhatSinhAfter
    {
        // Các trường dữ liệu thay thế cho subclasses
        private readonly string _tenDichVu;
        private readonly string _donViTinh;
        private readonly double _donGiaDinhMuc;
        private readonly bool _coChiuThueVAT;

        public DichVuPhatSinhAfter(string tenDichVu, string donViTinh, double donGiaDinhMuc, bool coChiuThueVAT)
        {
            _tenDichVu = tenDichVu;
            _donViTinh = donViTinh;
            _donGiaDinhMuc = donGiaDinhMuc;
            _coChiuThueVAT = coChiuThueVAT;
        }

        public string TenDichVu => _tenDichVu;
        public string DonViTinh => _donViTinh;
        public double DonGiaDinhMuc => _donGiaDinhMuc;
        public bool CoChiuThueVAT => _coChiuThueVAT;

        // Static Factory Methods tiện lợi
        public static DichVuPhatSinhAfter TaoPhiVanChuyen() 
            => new DichVuPhatSinhAfter("Phí vận chuyển nông dược tận nơi", "Chuyến", 50000, true);

        public static DichVuPhatSinhAfter TaoPhiBocXep() 
            => new DichVuPhatSinhAfter("Phí bốc xếp phân bón tại kho", "Bao", 5000, false);

        public static DichVuPhatSinhAfter TaoPhiBaoQuanKhoLanh() 
            => new DichVuPhatSinhAfter("Phí bảo quản kho lạnh thuốc BVTV", "Ngày", 20000, true);

        // Nạp động từ bảng cấu hình phụ phí trong Access
        public static DichVuPhatSinhAfter TaoTuCauHinh(string ten, string dvt, double donGia, bool vat)
            => new DichVuPhatSinhAfter(ten, dvt, donGia, vat);

        public double TinhThanhTien(double soLuong)
        {
            double tien = soLuong * _donGiaDinhMuc;
            return _coChiuThueVAT ? tien * 1.1 : tien;
        }
    }
    #endregion
}
