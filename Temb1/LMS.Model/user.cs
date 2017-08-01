using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;

namespace LMS.Model.Entites

{
    public class user
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Insert your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please insert a valid username")]
        public string User_Name { get; set; }
        public string Adress { get; set; }
        [DataType(DataType.Date)] 
        public string Birthday { get; set; }
        [Required]
        [EmailAddress]
        public string E_Mail { get; set; }
        [Required(ErrorMessage = "Please insert a valid password")]
        [MinLength(9)]    
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}