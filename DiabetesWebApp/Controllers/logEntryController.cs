using DiabetesManager.DataAccess;
using DiabetesManager.DataAccess.Repository.IRepository;
using DiabetesManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiabetesWebApp.Controllers
{
    public class logEntryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        //Constructor that uses dependancy injection to call on the data context service from Program.cs
        public logEntryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            //creates a list of objects from the logEntries table in the database
            IEnumerable<logEntry> objLogEntry = _unitOfWork.logEntry.GetAll();
            return View(objLogEntry);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(logEntry obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.logEntry.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Log entry created successfully";
                return RedirectToAction("Index"); 
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var logEntryFinder = _unitOfWork.logEntry.GetFirstOrDefault(u => u.entryId == id);

            if (logEntryFinder == null)
            {
                return NotFound();
            }

            return View(logEntryFinder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(logEntry obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.logEntry.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Log entry updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var logEntryFinder = _unitOfWork.logEntry.GetFirstOrDefault(u => u.entryId == id);

            if (logEntryFinder == null)
            {
                return NotFound();
            }

            return View(logEntryFinder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(logEntry obj)
        {           
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.logEntry.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Log entry deleted successfully";
            return RedirectToAction("Index");
           
           
        }
    }
}
