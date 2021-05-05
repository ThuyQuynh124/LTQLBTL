using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        //Usernamse không được để trống
        [Required(ErrorMessage="Username is required.")]
        public string Username { get; set; }
        //Password không được để trống
        [Required(ErrorMessage = "Password is required.")]
        //Định nghĩa DataType
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int RoleID { get; set; }

    }
}