using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forms.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        public ActionResult Index()
        {
            //    List<Task> tasks = new List<Task>()
            //    {
            //        new Task ("Brain", "finish assignment", false),
            //        new Task ("SETH", "finish assignment", true)
            //    };
            List<Task> currentTasks;
            currentTasks = (List<Task>)Session["tasks"] ?? new List<Task>();


            return View(currentTasks);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            var currentTasks = (List<Task>)Session["tasks"];
            if (ModelState.IsValid)
            {
                if (currentTasks == null)
                {
                    currentTasks = new List<Task>();
                }
                currentTasks.Add(newTask);
                Session["tasks"] = currentTasks;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

            
        }
    }
}