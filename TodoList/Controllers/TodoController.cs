﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Models;
using TodoList.Models.Entities;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        public ActionResult Index()
        {
            var context = new TodoDbContext();
            var items = context.TodoItems.ToList();
            return View(items);
        }

        public ActionResult Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public ActionResult Add(TodoItem model)
        {
            var context = new TodoDbContext();

            context.TodoItems.Add(model);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ChangeState(long itemId, bool done)
        {
            var context = new TodoDbContext();

            var item = context.TodoItems.First(x => x.Id == itemId);

            item.IsFinished = done;

            context.SaveChanges();

            return Json(new {success = true});
        }
    }
}