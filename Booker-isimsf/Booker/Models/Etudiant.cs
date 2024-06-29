using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Booker.Models
{
    public class Etudiant
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string CodeInscription { get; set; }
        public string Filiere { get; set; }
        public string Groupe { get; set; }

    }
}