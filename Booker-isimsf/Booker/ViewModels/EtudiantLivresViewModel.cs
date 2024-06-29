using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booker.Models;

namespace Booker.ViewModels
{
    public class EtudiantLivresViewModel
    {
        public Etudiant Etudiant { get; set; }
        public IQueryable<Livre> Livres { get; set; }
    }
}