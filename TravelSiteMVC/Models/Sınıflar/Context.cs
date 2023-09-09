using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TravelSiteMVC.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdressBlog> AdressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set;}
        public DbSet<Hakkimizda> Hakkimizdas  { get; set;}
        public DbSet<İletisim> iletisims  { get; set;}
        public DbSet<Yorumlar>  yorumlars { get; set;}
        
    }
}