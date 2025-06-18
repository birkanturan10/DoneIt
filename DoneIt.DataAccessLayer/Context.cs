using DoneIt.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoneIt.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-G13T04V9\\SQLEXPRESS;Database=DoneItDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
