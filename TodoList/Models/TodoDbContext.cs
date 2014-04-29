using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoList.Models.Entities;

namespace TodoList.Models
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}