using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("NHANVIENs")]
    public class NHANVIEN
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaCV { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set; }
        [MaxLength(15)]
        public string SoDT { get; set; }
        public virtual ICollection<CHUCVU> CHUCVUs { get; set; }
      
    }
}
