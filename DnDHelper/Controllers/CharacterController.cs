using DnDHelper.Models;
using DnDHelper.Models.ViewModel;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

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
        public ActionResult Details(int id = 1)
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
                catch(System.Exception e)
                {
                    return new HttpStatusCodeResult(500);
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
        public ActionResult Edit(int id, Character character)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Entry(character).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(character);
                }
            }
            return HttpNotFound();
        }

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            var character = _db.Characters.Find(id);            
            if (character == null)
                return HttpNotFound();
            var characterDetails = new CharacterDetails(character);
            return View(characterDetails);
        }

        // POST: Character/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,CharacterDetails charDetails)
        {
            try
            {
                var character = _db.Characters.Find(id);
                if (character != null)
                    _db.Entry(character).State = EntityState.Deleted;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
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
