using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("PHIEUDANGKIs")]
    public class PHIEUDANGKI
    {
        [Key]
        [StringLength(50)]
        public string MaPDK { get; set; }
        public string MaNV { get; set; }
        public DateTime Ngaydk { get; set; }
        public virtual ICollection<CTPHIEUDANGKI> CTPHIEUDANGKIs { get; set; }
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }


    }
}