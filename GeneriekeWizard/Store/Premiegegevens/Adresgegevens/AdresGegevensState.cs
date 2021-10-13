using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens
{
    public class AdresGegevensState
    {
        public Land Land { get; set; }
        public string Postcode { get; set; }
        public int Huisnummer { get; set; }
        public string Toevoeging { get; set; }

        //List landen toevoegen? 
        public AdresGegevensState(Land land, string postcode, int huisnummer, string toevoeging)
        {
            this.Land = land;
            this.Postcode = postcode;
            this.Huisnummer = huisnummer;
            this.Toevoeging = toevoeging;
        }
    }
}
