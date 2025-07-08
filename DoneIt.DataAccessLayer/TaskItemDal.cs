using DoneIt.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoneIt.DataAccessLayer
{
    public class TaskItemDal
    {
        private readonly Context _context;

        public TaskItemDal()
        {
            _context = new Context();
        }

        public void Add(TaskItem task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public List<TaskItem> GetAll()
        {
            return _context.TaskItems.ToList();
        }

        public void Delete(TaskItem task)
        {
            _context.TaskItems.Remove(task);
            _context.SaveChanges();
        }
    }
}
