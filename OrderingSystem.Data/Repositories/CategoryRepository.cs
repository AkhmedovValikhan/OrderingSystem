using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Data.Infrastructure;
using OrderingSystem.Domain;

namespace OrderingSystem.Data.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        
    }
    public class CategoryRepository : RepositoryBase<Category>
    {
    }
}
