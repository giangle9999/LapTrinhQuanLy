using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiThucHanh136.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        public string SanPhamID { get; set; }
        public string TenSanPham { get; set; }
    }
}