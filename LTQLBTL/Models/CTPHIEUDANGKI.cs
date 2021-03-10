using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("CTPHIEUDANGKIs")]
    public class CTPHIEUDANGKI
    {
        [Key]
        [StringLength(50)]
        public string MaCTPDK { get; set; }
        public string MaPDK { get; set; }
        public string MaKH { get; set; }
        public int SoNguoi { get; set; }
        public DateTime NgayDen { get; set; }
        public DateTime NgayDi { get; set; }
        public virtual PHIEUDANGKI PHIEUDANGKI { get; set; }
    }
}