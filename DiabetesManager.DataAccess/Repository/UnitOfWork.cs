using DiabetesManager.DataAccess.Repository.IRepository;
using DiabetesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesManager.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _dataBase;

        public UnitOfWork(DataContext dataBase)
        {
            _dataBase = dataBase;
            logEntry = new LogEntryRepository(_dataBase);
            userSetting = new UserSettingRepository(_dataBase);
        }
        public ILogEntryRepository logEntry { get; private set; }
        public IUserSettingRepository userSetting { get; private set; } 

        public void Save()
        {
            _dataBase.SaveChanges();
        }
    }
}
