using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.UI.Web.Controllers
{
    public class ArtisteController : Controller
    {
        IServiceArtiste sa;
        public ArtisteController(IServiceArtiste sa)
        {
            this.sa = sa;
        }
        // GET: ArtisteController
        public ActionResult Index()
        {
            return View(sa.GetMany());
           
        }

        // GET: ArtisteController/Details/5
        public ActionResult Details(int id)
        {
            return View(sa.GetById(id));
        }

        // GET: ArtisteController/Create
        public ActionResult Create()
        {
          
            return View();

        }

        // POST: ArtisteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Artiste collection)
        {
            try
            {
                sa.Add(collection);
                sa.Commit();
              ;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArtisteController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(sa.GetById(id));
        }

        // POST: ArtisteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Artiste collection)
        {
            try
            {
                sa.Update(collection);
                sa.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArtisteController/Delete/5
        public ActionResult Delete(int id)
        {
           
            return View(sa.GetById(id));
        }

        // POST: ArtisteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                sa.Delete(sa.GetById(id));
                sa.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
