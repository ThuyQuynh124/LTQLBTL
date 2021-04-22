using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    public class TINTUC
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
    }
}