using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Data.Infrastructure
{
    public interface IContextFactory
    {
        OrderingSystemEntities Init();
    }

    public class ContextFactory : IContextFactory
    {
        private OrderingSystemEntities _dbContext;
        public OrderingSystemEntities Init()
        {
            return _dbContext ?? (_dbContext = new OrderingSystemEntities());
        }
    }
}
