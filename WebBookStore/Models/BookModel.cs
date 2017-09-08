using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBookStore.Models
{
    public class BookModel
    {
               
        public int BookModelID { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(13)]        
        public string ISBN { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(5)]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(5)]
        public string Author { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(5)]
        public string Genre { get; set; }

        public bool isDeleted { get; set; }

        public string Description { get; set; }
        public byte[] Picture { get; set; }


        //public virtual ICollection<ImageModel> Images { get; set; }

    }
}