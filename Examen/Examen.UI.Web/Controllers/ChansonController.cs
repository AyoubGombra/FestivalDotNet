using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.UI.Web.Controllers
{
    public class ChansonController : Controller
    {
        IServiceChanson sc;
        IServiceArtiste sa;
        public ChansonController(IServiceChanson sc , IServiceArtiste sa )
        {
            this.sc = sc;
            this.sa = sa;
        }
        // GET: ChansonController1
        public ActionResult Index()
        {
           
            return View(sc.GetMany());
        }




        public ActionResult Sort()
        {
            return View(sc.SortChanson());
        }

        // GET: ChansonController1/Details/5
        public ActionResult Details(int id)
        {
            return View(sc.GetById(id));
        }

        // GET: ChansonController1/Create
        public ActionResult Create()
        {
            ViewBag.Artistes= new SelectList(sa.GetMany(), "ArtisteId", "ArtisteId");
            return View();
        }

        // POST: ChansonController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chanson collection)
        {
            try
            {

                sc.Add(collection);
                sc.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(sc.GetById(id));
        }

        // POST: ChansonController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Chanson collection)
        {
            try
            {
                sc.Update(collection);
                sc.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View(sc.GetById(id))  ;  
                }

        // POST: ChansonController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                sc.Delete(sc.GetById(id));
                sc.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
