using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingSystem.Domain
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}
