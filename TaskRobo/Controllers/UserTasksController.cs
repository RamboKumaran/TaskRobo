using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TaskRobo.DataAccess;
using TaskRobo.DataAccess.Repository;

namespace TaskRobo.Controllers
{
    public class UserTasksController : Controller
    {
        private TaskRoboDbContext db = new TaskRoboDbContext();
        private ITaskRepository taskRepository = new TaskRepository();

        // GET: UserTasks
        public ActionResult Index()
        {
            return View(taskRepository.GetTasks());
        }

        // GET: UserTasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserTask userTask = taskRepository.GetTask(id.Value);
            if (userTask == null)
            {
                return HttpNotFound();
            }
            return View(userTask);
        }

        // GET: UserTasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskId,TaskTitle,TaskContent,TaskStatus")] UserTask userTask)
        {
            if (ModelState.IsValid)
            {
                taskRepository.AddTask(userTask);
                return RedirectToAction("Index");
            }

            return View(userTask);
        }

        // GET: UserTasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserTask userTask = taskRepository.GetTask(id.Value);
            if (userTask == null)
            {
                return HttpNotFound();
            }
            return View(userTask);
        }

        // POST: UserTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskId,TaskTitle,TaskContent,TaskStatus")] UserTask userTask)
        {
            if (ModelState.IsValid)
            {
               taskRepository.UpdateTask(userTask);
                return RedirectToAction("Index");
            }
            return View(userTask);
        }

        // GET: UserTasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserTask userTask = taskRepository.GetTask(id.Value);
            if (userTask == null)
            {
                return HttpNotFound();
            }
            return View(userTask);
        }

        // POST: UserTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           taskRepository.DeleteTask(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
