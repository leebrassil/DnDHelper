using DnDHelper.Models;
using DnDHelper.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnDHelper.Controllers
{
    public class CharacterController : Controller
    {
        DnDHelperContext _db = new DnDHelperContext();
        // GET: Character
        public ActionResult Index()
        {
            var model = _db.Characters.ToList();
            return View(model);
        }

        // GET: Character/Details/5
        public ActionResult Details(int id)
        {
            var character = _db.Characters.Find(id);
            if(character != null)
                return View(new CharacterDetails(character));
            return RedirectToAction("Index");
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(Character character)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _db.Characters.Add(character);
                    _db.SaveChanges();
                    return RedirectToAction("Details", new { id = character.Id });

                }
                catch
                {
                    return View();
                }
            }
            return View(character);       
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            var character = _db.Characters.Find(id);
            if (character != null)
                return View(character);
            else
                return RedirectToAction("Index");
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
                _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
