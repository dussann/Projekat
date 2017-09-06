using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebBookStore.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("WebBookStoreBaza") { }
        public DbSet<BookModel> BookModels { get; set; }
        public DbSet<UserAccountModel> UserAccountModels { get; set; }
        public DbSet<ImageModel> ImageModels { get; set; }
        
    }
}