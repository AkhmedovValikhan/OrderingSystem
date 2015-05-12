using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Data.Infrastructure;
using OrderingSystem.Domain;

namespace OrderingSystem.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        
    }
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(IContextFactory factory)
                :base(factory)
            {
                 
            }
    }
}
