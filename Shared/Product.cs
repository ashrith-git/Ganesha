using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPASBlazor.Shared
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
