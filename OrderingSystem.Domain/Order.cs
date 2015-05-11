using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingSystem.Domain
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPerformed { get; set; }
        public int CategoryID { get; set; }
        public int PerformerID { get; set; }

        public User Performer { get; set; }
        public Category Category { get; set; }


        public DateTime? CreationDate { get; set; }
        public DateTime? PerformanceDate { get; set; }

        public virtual List<Skill> RequiredSkills { get; set; }

    }
}
