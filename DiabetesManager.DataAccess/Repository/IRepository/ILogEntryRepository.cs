using DiabetesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesManager.DataAccess.Repository.IRepository
{
    public interface ILogEntryRepository : IRepository<logEntry>
    {
        void Update(logEntry obj);
   
    }
}
