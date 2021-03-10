using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("CHUCVUs")]
    public class CHUCVU
    {

        [Key]
        [StringLength(50)]
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }

    }
}