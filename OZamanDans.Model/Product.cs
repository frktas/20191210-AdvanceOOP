using OZamanDans.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.Model
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
