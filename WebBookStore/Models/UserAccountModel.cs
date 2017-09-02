using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBookStore.Models
{
    [Table("UserAccountT")]
    public class UserAccountModel
    {     
       
        public int UserAccountModelID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Display(Name ="Korisnicko ime")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[NotMapped]
        //[Required]
        //[System.Web.Mvc.Compare("Password")]
        //[DataType(DataType.Password)]
        //public string PasswordRepeat { get; set; }

        [Display(Name ="Vasa Email adresa")]
        [DataType(DataType.EmailAddress,ErrorMessage ="NIste pravilno uneli mail")]
        public string Mail { get; set; }

        public bool isDeleted { get; set; }

        

        public virtual ImageModel Image { get; set; }

    }
}