using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VU_Test.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [DataType(dataType:DataType.Password)]
        public string Password { get; set; }
        [DataType(dataType: DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Messege { get; set; }
    }
}