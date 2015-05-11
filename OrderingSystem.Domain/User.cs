using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Domain
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int AccountID { get; set; }
        public virtual Account Account { get; set; }

        public virtual List<Skill> Skills { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
