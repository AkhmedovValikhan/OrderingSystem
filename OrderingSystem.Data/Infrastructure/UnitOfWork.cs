using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderingSystemEntities _context;
        public UnitOfWork()
        {
            _context = new OrderingSystemEntities();
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
