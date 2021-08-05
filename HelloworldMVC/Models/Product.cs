using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloworldMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool isOnsale { get; set; }
        public string pictureUrl { get; set; }
    }
}
