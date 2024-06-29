using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Booker.Models;
using Booker.ViewModels;
using System.Data.Entity;

namespace Booker.Controllers
{
    public class LivresController : Controller
    {
        private ApplicationDbContext _context;

        public LivresController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {

            var livres = _context.Livres.ToList();

            return View(livres);
        }

        public ActionResult New()
        {
            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year - 100, 101).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");

            var viewModel = new LivreFormViewModel
            {
                Livre = new Livre()
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Livre livre)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new LivreFormViewModel
                {
                    Livre = new Livre()
                };

                return View("BookForm", viewModel);
            }

            if (livre.Id == 0)
            {
                _context.Livres.Add(livre);
            }
            else
            {
                var bookInDb = _context.Livres.Single(c => c.Id == livre.Id);

                bookInDb.Titre = livre.Titre;
                bookInDb.Auteur = livre.Auteur;
                bookInDb.AnneePublication = livre.AnneePublication;
                bookInDb.NombreEnStock = livre.NombreEnStock;
                bookInDb.NomberEmprunte = livre.NomberEmprunte;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Livres");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            if (id > 0)
            {
                var bookInDb = _context.Livres.SingleOrDefault(c => c.Id == id);

                _context.Livres.Remove(bookInDb);
                _context.SaveChanges();
            }


            return RedirectToAction("Index", "Livres");

        }


        public ActionResult Details(int id)
        {


            if (Session["Etudiant"] != null) {
                int etudiantId = Convert.ToInt32(Session["Etudiant"]);
                var cBook = _context.EtudiantLivres.SingleOrDefault(c => c.LivreId == id && c.EtudiantId == etudiantId);

                bool rentedBySession;

                if (cBook != null)
                    rentedBySession = true;
                else
                    rentedBySession = false;

                var viewModel = new LivreEtudiantViewModel
                {
                    Livre = _context.Livres.SingleOrDefault(c => c.Id == id),
                    RentedBySession = rentedBySession
                };

                if (viewModel.Livre == null)
                    return HttpNotFound();

                return View(viewModel);
            }
            else
            {
                var viewModel = new LivreEtudiantViewModel
                {
                    Livre = _context.Livres.SingleOrDefault(c => c.Id == id),
                    RentedBySession = false
                };
                if (viewModel.Livre == null)
                    return HttpNotFound();

                return View(viewModel);
            }
            
        }


        public ActionResult Edit(int id)
        {

            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year - 100, 101).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");


            var livre = _context.Livres.SingleOrDefault(c => c.Id == id);

            if (livre == null)
                return HttpNotFound();

            var viewModel = new LivreFormViewModel
            {
                Livre = livre
            };

            return View("BookForm", viewModel);
        }

        public ActionResult Return()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Etudiants");
        }

        public ActionResult AddCustomerBook(int id)
        {

            var livre = _context.Livres.SingleOrDefault(c => c.Id == id);

            if (id > 0 && livre.NombreEnStock > 0)
            {
                var model = new EtudiantLivres()
                {
                    LivreId = id,
                    EtudiantId = Convert.ToInt32(Session["Etudiant"])
                };

                livre.NombreEnStock--;
                livre.NomberEmprunte++;

                _context.EtudiantLivres.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
                
        }
        public ActionResult ReturnBook(int id)
        {
            if (id > 0 && Session["Etudiant"] != null)
            {
                var livre = _context.Livres.SingleOrDefault(c => c.Id == id);

                int etudiantId = Convert.ToInt32(Session["Etudiant"]);
                var cBook = _context.EtudiantLivres.SingleOrDefault(c => c.LivreId == id && c.EtudiantId == etudiantId);


                livre.NombreEnStock++;
                livre.NomberEmprunte--;

                _context.EtudiantLivres.Remove(cBook);
                _context.SaveChanges();


                return RedirectToAction("Index", "Livres");
            }

            return HttpNotFound();
        }
    }
}