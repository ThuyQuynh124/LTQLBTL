using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("BANGLUONGs")]
    public class BANGLUONG
    {
        [Key]
        [StringLength(50)]
        public string MaLuong { get; set; }
        public string MaNV { get; set; }
        public float TienLuong { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

        
    }
}