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
    public class EtudiantsController : Controller
    {
        private ApplicationDbContext _context;

        public EtudiantsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var etudiants = _context.Etudiants.ToList();

            Session.Remove("Etudiant");

            return View(etudiants);
        }

        public ActionResult New()
        {
            var viewModel = new EtudiantFormViewModel
            {
                Etudiant = new Etudiant()
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Etudiant etudiant)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EtudiantFormViewModel
                {
                    Etudiant = new Etudiant()
                };

                return View("CustomerForm", viewModel);
            }

            if (etudiant.Id == 0)
            {
                _context.Etudiants.Add(etudiant);
            }
            else
            {
                var etudiantInDb = _context.Etudiants.Single(c => c.Id == etudiant.Id);

                etudiantInDb.Name = etudiant.Name;
                etudiantInDb.Prenom = etudiant.Prenom;
                etudiantInDb.Email = etudiant.Email;
                etudiantInDb.Filiere = etudiant.Filiere;
                etudiantInDb.Groupe = etudiant.Groupe;
                etudiantInDb.CodeInscription = etudiant.CodeInscription;

            }
            _context.SaveChanges();

            return RedirectToAction("Details/" + etudiant.Id, "Etudiants");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            
            if (id > 0)
            {
                var etudiantInDb = _context.Etudiants.SingleOrDefault(c => c.Id == id);

                var livres = (from cb in _context.EtudiantLivres
                             join b in _context.Livres on cb.LivreId equals b.Id
                             where cb.EtudiantId == etudiantInDb.Id
                             select cb);

                foreach(var cbook in livres)
                {
                    var livre = _context.Livres.SingleOrDefault(c => c.Id == cbook.LivreId);

                    livre.NombreEnStock++;
                    livre.NomberEmprunte--;
                }

                _context.EtudiantLivres.RemoveRange(livres);
                _context.Etudiants.Remove(etudiantInDb);
                _context.SaveChanges();
            }
            
            
            return RedirectToAction("Index", "Etudiants");
            
        }


        public ActionResult Details(int id)
        {
            var etudiant = _context.Etudiants.SingleOrDefault(c => c.Id == id);

            var livres = (from b in _context.Livres
                         join cb in _context.EtudiantLivres on b.Id equals cb.LivreId
                         where cb.EtudiantId == etudiant.Id
                         select b);

            Session.Add("Etudiant", id);

            var viewModel = new EtudiantLivresViewModel
            {
                Etudiant = etudiant,
                Livres = livres
            };

            if (etudiant == null)
                return HttpNotFound();
            
            return View(viewModel);
        }


        public ActionResult Edit(int id)
        {
            var etudiant = _context.Etudiants.SingleOrDefault(c => c.Id == id);

            if (etudiant == null)
                return HttpNotFound();

            var viewModel = new EtudiantFormViewModel
            {
                Etudiant = etudiant
            };

            return View("CustomerForm", viewModel);
        }


        public ActionResult Browse(int id)
        {
            var etudiant = _context.Etudiants.SingleOrDefault(c => c.Id == id);

            if (etudiant == null)
                return HttpNotFound();

            Session.Add("Etudiant", id);

            return RedirectToAction("Index", "Livres");
        }

        

    }
}
