using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("LOAIPHONGs")]
    public class LOAIPHONG
    {
        [Key]
        [StringLength(50)]
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string ChiTiet { get; set; }
       
    }
}