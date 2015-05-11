using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Data.Infrastructure;
using OrderingSystem.Domain;

namespace OrderingSystem.Data.Repositories
{
    public interface ISettingsRepository : IRepository<Settings>
    {
        
    }
    public class SettingsRepository : RepositoryBase<Settings>
    {
    }
}
