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

        public IActionResult Delete(int id)
        {
            var task = _taskItemManager.GetAll().FirstOrDefault(x => x.TaskID == id);
            if (task != null)
            {
                _taskItemManager.Delete(task);
            }
            return RedirectToAction("Index");
        }

        public IActionResult ToggleStatus(int id)
        {
            var task = _taskItemManager.GetAll().FirstOrDefault(x => x.TaskID == id);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
                _taskItemManager.Update(task);
            }
            return RedirectToAction("Index");
        }
    }
}
