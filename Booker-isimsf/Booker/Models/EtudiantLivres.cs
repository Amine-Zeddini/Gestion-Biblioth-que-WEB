using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booker.Models
{
    public class EtudiantLivres
    {
        public int Id { get; set; }

        public int EtudiantId { get; set; }

        public int LivreId { get; set; }
    }
}