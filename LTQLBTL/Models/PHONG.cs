using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("PHONGs")]
    public class PHONG
    {
        [Key]
        [StringLength(50)]
        public string MaPhong { get; set; }
        public string TenLoaiPHong { get; set; }
        public string HienTrang { get; set; }
        public int SoNguoi { get; set; }

        [MaxLength(15)]
        public string SoDTPhong { get; set; }
    }
}