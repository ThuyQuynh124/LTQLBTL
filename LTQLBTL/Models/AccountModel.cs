using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLBTL.Models
{
    public class AccountModel
    {
        //Usernamse không được để trống
        [Required(ErrorMessage="Username is required.")]
        public string Username { get; set; }
        //Password không được để trống
        [Required(ErrorMessage = "Password is required.")]
        //Định nghĩa DataType
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}