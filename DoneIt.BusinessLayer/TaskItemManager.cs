﻿using DoneIt.DataAccessLayer;
using DoneIt.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DoneIt.BusinessLayer
{
    public class TaskItemManager
    {
        private readonly TaskItemDal? _taskItemDal;

        public TaskItemManager()
        {
            _taskItemDal = new TaskItemDal();
        }

        public void Add(TaskItem task)
        {
            _taskItemDal?.Add(task);
        }

        public List<TaskItem> GetAll()
        {
            return _taskItemDal.GetAll();
        }
    }
}
