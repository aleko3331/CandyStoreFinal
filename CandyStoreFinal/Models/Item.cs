using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Models
{
    public class Item
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public double Price { set; get; }
        public string PhotoUrl { set; get; }
        public int Quantity { get; set; }
    }
}
