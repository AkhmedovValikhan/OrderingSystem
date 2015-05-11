using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Domain;

namespace OrderingSystem.Data.Configuration
{
    public class SettingsConfiguration : EntityTypeConfiguration<Settings>
    {
        public SettingsConfiguration()
        {
            ToTable("Settings");
            Property(s => s.Сommission).IsRequired();
        }
    }
}
