using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingSystem.Domain
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Name { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
