//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyPhuKienDienTu
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietHoaDonBans = new HashSet<ChiTietHoaDonBan>();
            this.ChiTietHoaDonNhaps = new HashSet<ChiTietHoaDonNhap>();
        }
    
        public int MaSanPham { get; set; }
        public int MaThuongHieu { get; set; }
        public int MaLoai { get; set; }
        public string TenSanPham { get; set; }
        public string MauSac { get; set; }
        public string MoTa { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public int ThoiLuongBaoHanh { get; set; }
        public int SoLuongTonKho { get; set; }
    
        public virtual Loai Loai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}