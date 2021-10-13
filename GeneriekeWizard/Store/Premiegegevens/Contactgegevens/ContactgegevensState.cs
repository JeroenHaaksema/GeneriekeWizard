using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Contactgegevens
{
    public class ContactgegevensState
{
        public string EmailAdres { get; set; }
        public string TelefoonNummer { get; set; }

        public ContactgegevensState(string emailAdres, string telefoonNummer)
        {
            this.EmailAdres = emailAdres;
            this.TelefoonNummer = telefoonNummer;
        }
    }
}
