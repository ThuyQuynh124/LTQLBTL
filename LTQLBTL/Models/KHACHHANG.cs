using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("KHACHHANGs")]
    public class KHACHHANG
    {
        [Key]
        [StringLength(50)]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }

        [MaxLength(15)]
        public string SoDienThoai { get; set; }
    }

}
