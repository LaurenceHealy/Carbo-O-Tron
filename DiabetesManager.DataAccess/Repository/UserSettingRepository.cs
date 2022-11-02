using DiabetesManager.DataAccess.Repository.IRepository;
using DiabetesManager.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesManager.DataAccess.Repository
{
    public class UserSettingRepository : Repository<userSetting>, IUserSettingRepository
    {
        private DataContext _dataBase;

        public UserSettingRepository(DataContext dataBase) : base(dataBase)
        {
            _dataBase = dataBase;
        }

        public void Update(userSetting obj)
        {
            _dataBase.userSettings.Update(obj);
        }
    }
}
