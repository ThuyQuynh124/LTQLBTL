using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQLBTL.Models
{
    [Table("THONGTIN")]
    public class THONGTIN
    {
        [Key]
        public int ThongTinID { get; set; }
        public string TieuDe { get; set; }
        [AllowHtml]
        public string NoiDung { get; set; }
    }
}