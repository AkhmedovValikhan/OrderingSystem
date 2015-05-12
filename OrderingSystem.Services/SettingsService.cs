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
    public interface ISettingsService
    {
        IEnumerable<Settings> GetAllSettings();
        Settings GetSettings(int id);
        void CreateSettings(Settings order);
        void SaveSettings();
    }

    public class SettingsService : ISettingsService
    {
        private readonly ISettingsRepository _settingsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SettingsService(ISettingsRepository repo, IUnitOfWork unit)
        {
            _settingsRepository = repo;
            _unitOfWork = unit;
        }
        public IEnumerable<Settings> GetAllSettings()
        {
            return _settingsRepository.All();
        }

        public Settings GetSettings(int id)
        {
            return _settingsRepository.FindById(id);
        }

        public void CreateSettings(Settings order)
        {
            _settingsRepository.Add(order);
        }

        public void SaveSettings()
        {
            _unitOfWork.Commit();
        }
    }
}
