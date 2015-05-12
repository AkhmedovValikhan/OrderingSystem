using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.Data.Infrastructure;
using OrderingSystem.Data.Repositories;
using OrderingSystem.Domain;

namespace OrderingSystem.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void CreateOrder(Order order);
        void SaveOrder();
        void AddRequiredSkills(Order order, params Skill[] skills);

    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ISkillRepository _skillRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork, ISkillRepository skillRepository)
        {
            _orderRepository = orderRepository;
            _skillRepository = skillRepository;
            _unitOfWork = unitOfWork;
        }
        
        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.All();
        }

        public Order GetOrder(int id)
        {
            return _orderRepository.FindById(id);
        }

        public void CreateOrder(Order order)
        {
            order.CreationDate = DateTime.Now;
            _orderRepository.Add(order);
        }

        public void SaveOrder()
        {
            _unitOfWork.Commit();
        }


        public void AddRequiredSkills(Order order, params Skill[] skills)
        {
            foreach (var skill in skills)
            {

                if (_skillRepository.Find(s => s.Name == skill.Name) == null)
                {
                    _skillRepository.Add(skill);
                }

                order.RequiredSkills.Add(skill);
            }
        }
    }
}
