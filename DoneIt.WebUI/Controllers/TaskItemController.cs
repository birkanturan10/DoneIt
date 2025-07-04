using DoneIt.BusinessLayer;
using DoneIt.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace DoneIt.WebUI.Controllers
{
    public class TaskItemController : Controller
    {
        private readonly TaskItemManager _taskItemManager;

        public TaskItemController()
        {
            _taskItemManager = new TaskItemManager();
        }

        public IActionResult Index()
        {
            List<TaskItem> tasks = _taskItemManager.GetAll(); 
            return View(tasks);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TaskItem task)
        {
            task.Date = DateTime.Now;
            _taskItemManager.Add(task);
            return RedirectToAction("Index");
        }
    }
}
