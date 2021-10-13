using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.BetaaltermijnEnum;
using static GeneriekeWizard.Domain_Objects.BetaalTypeEnum;

namespace GeneriekeWizard.Services
{
    public class PremieGegevensModel
    {
        //Contactgegevens
        [Required]
        [EmailAddress(ErrorMessage = "Het opgegegeven e-mailadres is onjuist")]
        public string EmailAdres { get; set; }
        [Required]
        [RegularExpression("^0{1}[0-9]{9}$", ErrorMessage = "Het ingevoerde telefoonnummer is onjuist")]
        public string TelefoonNummer { get; set; }

        //Adresgegevens
        //Dropdown, met een standaard selectie. Daarom geen validators
        public Land Land { get; set; } = new Land { Id = 1, Naam = "Nederland" };
        [Required]
        [RegularExpression("^[1-9]{1}[0-9]{3}[a-zA-Z]{2}$", ErrorMessage = "De ingevoerde postcode is onjuist")]
        public string Postcode { get; set; }
        [Required]
        [Range(1, 500, ErrorMessage = "Voer alstublieft een geldig huisnummer in")]
        public int Huisnummer { get; set; }
        [MinLength(0)]
        [MaxLength(3, ErrorMessage = "Voer alstublieft een geldige toevoeging in")]
        public string Toevoeging { get; set; }

        [Required(ErrorMessage = "Vul alstublieft uw rekeningnummer in")]
        public string RekeningNummer { get; set; }

        [Range(typeof(Betaaltermijn), nameof(Betaaltermijn.Maand),
        nameof(Betaaltermijn.Jaar), ErrorMessage = "Maakt u hierin alstublieft een keuze.")]
        [Required]
        public Betaaltermijn BetaalTermijn { get; set; }

        [Required]
        [Range(typeof(BetaalType), nameof(BetaalType.Acceptgiro),
        nameof(BetaalType.iDeal), ErrorMessage = "Maakt u hierin alstublieft een keuze.")]
        public BetaalType BetaalType { get; set; }
    }
}
