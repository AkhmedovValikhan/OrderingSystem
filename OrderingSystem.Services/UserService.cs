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
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void CreateUser(User order);
        void SaveUser();
        void AddSkills(User user, params Skill[] skils);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ISkillRepository _skillsRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUserRepository repo, IAccountRepository accRepo, ISkillRepository skillsRepo, IUnitOfWork unit)
        {
            _userRepository = repo;
            _skillsRepository = skillsRepo;
            _accountRepository = accRepo;
            _unitOfWork = unit;
        }
        public IEnumerable<User> GetUsers()
        {
            return _userRepository.All();
        }

        public User GetUser(int id)
        {
            return _userRepository.FindById(id);
        }

        public void CreateUser(User order)
        {
            var userAcc = new Account();
            _accountRepository.Add(userAcc);
            order.Account = userAcc;
            _userRepository.Add(order);
        }

        public void AddSkills(User user, params Skill[] skills)
        {
            foreach (var skill in skills)
            {
                
                if (_skillsRepository.Find(s => s.Name == skill.Name) == null)
                {
                    _skillsRepository.Add(skill);
                }
                
                user.Skills.Add(skill);
            }
        }

        public void SaveUser()
        {
            _unitOfWork.Commit();
        }
    }
}
