using DiabetesManager.DataAccess;
using DiabetesManager.DataAccess.Repository.IRepository;
using DiabetesManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiabetesWebApp.Controllers
{
    
    public class userSettingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        //Constructor that uses dependancy injection to call on the data context service from Program.cs
        public userSettingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            //creates a list of objects from the logEntries table in the database
            IEnumerable<userSetting> objUserSetting = _unitOfWork.userSetting.GetAll();
            return View(objUserSetting);
        }
        
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var userSettingFinder = _unitOfWork.userSetting.GetFirstOrDefault(u => u.settingId == id);

            if (userSettingFinder == null)
            {
                return NotFound();
            }

            return View(userSettingFinder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(userSetting obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.userSetting.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "User settings updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
