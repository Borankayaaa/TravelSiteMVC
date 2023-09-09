using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelSiteMVC.Models.Sınıflar
{
    public class AdressBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public  string AcıkAdress { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set;}
         public string Konum { get; set; }
         
    }
}