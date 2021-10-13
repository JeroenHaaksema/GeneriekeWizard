using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.GeslachtEnum;

namespace GeneriekeWizard.Services
{
    public class PersoonModel
    {
        [Required]
        public string Voorletters { get; set; }
        [MinLength(1)]
        [MaxLength(7)]
        public string Tussenvoegsel { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(30, ErrorMessage = "Maximum lengte is 30 karakters")]
        public string Achternaam { get; set; }
        [Required]
        [Range(typeof(Geslacht), nameof(Geslacht.Man),
        nameof(Geslacht.Neutraal), ErrorMessage = "Maakt u hierin alstublieft een keuze.")]
        public Geslacht Geslacht { get; set; }
        public string BSN { get; set; }

    }
}
