using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ScheduleController : Controller
    {
        private readonly DataManager dataManager;
        public ScheduleController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        public IActionResult Index(string codeWord)
        {
            //var entity = dataManager.Schedules.GetSchedulesByCodeWord(codeWord);
            return View(/*entity*/);
        }

    }
}
