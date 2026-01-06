using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
        
    public class Sales
    {
        [Key]
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public int Qty { get; set; }
        public double SaleTotal { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}