using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("DICHVUs")]
    public class DICHVU
    {
        [Key]
        [StringLength(50)]
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public float GiaDV { get; set; }
        public float Luongton { get; set; }
    }
}