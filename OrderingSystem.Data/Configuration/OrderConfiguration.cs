using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Domain;

namespace OrderingSystem.Data.Configuration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Orders");
            
            Property(o => o.Title).IsRequired().HasMaxLength(40);
            Property(o => o.Description).IsRequired().HasMaxLength(250);
            Property(o => o.Price).IsRequired().HasPrecision(10, 2);
            Property(o => o.CreationDate).IsRequired();

            HasRequired(o => o.Category).WithMany(c => c.Orders);
            HasOptional(o => o.Performer).WithMany(u => u.Orders);
            HasMany(o => o.RequiredSkills).WithMany(s => s.Orders);
        }
    }
}
