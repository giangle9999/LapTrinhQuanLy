﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiTapLon136.Models
{
    [Table("Xuất Kho")]
    public class XuatKho
    {
        [Key]
        [Display(Name = "Mã Phiếu Nhập")]
        public string MaPhieuXuat { get; set; }

        [Display(Name = "Ngày Nhập")]
        public string NgayXuat { get; set; }

        [Display(Name = "Mã Hàng")]
        public string MaHang { get; set; }

        [Display(Name = "Tên Hàng")]
        public string TenHang { get; set; }

        [Display(Name = "Số Lượng")]
        public int SoLuong { get; set; }

        [Display(Name = "Đơn Giá")]
        public int DonGia { get; set; }

        [Display(Name = "Thành Tiền")]
        public int ThanhTien { get; set; }
    }
}