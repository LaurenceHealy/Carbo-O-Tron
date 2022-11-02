using DiabetesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesManager.DataAccess.Repository.IRepository
{
    public interface IUserSettingRepository : IRepository<userSetting>
    {
        void Update(userSetting obj);
   
    }
}
