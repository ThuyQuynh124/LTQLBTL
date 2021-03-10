using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("CTHOADONs")]
    public class CTHOADON
    {
        [Key]
        [StringLength(50)]
        public string MaCTHD { get; set; }
        public string MaHD { get; set; }
        public string MaPDK { get; set; }
        public string PHONG { get; set; }
        public float TienPhong { get; set; }
        public float TienDV { get; set; }
        public virtual HOADON HOADON { get; set; }
        public virtual PHIEUDANGKI PHIEUDANGKI { get; set; }
    }
}
