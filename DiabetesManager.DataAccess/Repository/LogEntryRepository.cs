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
    public class LogEntryRepository : Repository<logEntry>, ILogEntryRepository
    {
        private DataContext _dataBase;

        public LogEntryRepository(DataContext dataBase) : base(dataBase)
        {
            _dataBase = dataBase;
        }

        public void Update(logEntry obj)
        {
            _dataBase.logEntries.Update(obj);
        }
    }
}
