using DiabetesManager.DataAccess.Repository.IRepository;
using DiabetesManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiabetesWebApp.Controllers
{
    public class insulinCalculatorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        //Constructor that uses dependancy injection to call on the data context service from Program.cs
        public insulinCalculatorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            //creates a list of objects from the logEntries table in the database
            IEnumerable<userSetting> objUserSetting = _unitOfWork.userSetting.GetAll();
            return View(objUserSetting);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
