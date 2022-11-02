using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesManager.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILogEntryRepository logEntry { get; }
        IUserSettingRepository userSetting { get; }

        void Save();
    }
}
