using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Domain;

namespace OrderingSystem.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            HasMany(u => u.Orders).WithOptional(o => o.Performer);
            HasMany(u => u.Skills).WithMany(s => s.Users);
            HasRequired(u => u.Account).WithRequiredDependent(a => a.User);

            Property(u => u.UserName).IsRequired().HasMaxLength(30);
        }
    }
}
