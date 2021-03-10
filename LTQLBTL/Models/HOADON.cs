using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("HOADONs")]
    public class HOADON
    {
        [Key]
        [StringLength(50)]
        public string MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongTien { get; set; }
        public string NhanVienLap { get; set; }
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }
    }
}
