using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;
using ASF.UI.WbSite.Services.Cache;

namespace ASF.UI.WbSite.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var VarCategoryProcess = new CategoryProcess ();
            return View(VarCategoryProcess.SelectList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                //var cp = new CategoryProcess();
                //cp.insertCategory(category);
                DataCache.Instance.CategoryListRemove();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }
        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                var cp = new CategoryProcess();
                cp.editCategory(category);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var cp = new CategoryProcess();

            return View(cp.findCategory(id));
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                var cp = new CategoryProcess();
                cp.deleteCategory(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
