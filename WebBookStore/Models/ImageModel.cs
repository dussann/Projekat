using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBookStore.Models
{
   
    [Table("ImageT")]
    public class ImageModel
    {   
        //Evo je neka promena  
        [ForeignKey("UserAccountModel")]
        public int ImageModelID { get; set; }
        public bool isLogImage { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; } 

        public virtual UserAccountModel UserAccountModel { get; set; }
        public virtual BookModel BookModel { get; set; }
    }
}