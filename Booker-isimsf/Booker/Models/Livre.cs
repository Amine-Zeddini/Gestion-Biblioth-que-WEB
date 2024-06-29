using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Booker.Models
{
    public class Livre
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name = "Titre")]

        public string Titre { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Auteur")]
        public string Auteur { get; set; }

        [Required]
        [Range(1900, 2019)]
        [Display(Name = "Année Publication")]
        public int AnneePublication { get; set; }

        [Display(Name = "Nombre en stock")]
        public int NombreEnStock { get; set; }

        public int NomberEmprunte { get; set; }
    }
}