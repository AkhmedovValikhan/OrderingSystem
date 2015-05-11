using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingSystem.Domain
{
    public class Account
    {
        public int AccountID { get; set; }
        public decimal Balance { get; set; }
        public virtual User User { get; set; }
    }
}
