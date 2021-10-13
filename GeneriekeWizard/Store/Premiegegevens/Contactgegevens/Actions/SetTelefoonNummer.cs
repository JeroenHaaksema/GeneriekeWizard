using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Contactgegevens.Actions
{
    public class SetTelefoonNummer
{
        public string TelefoonNummer { get; set; }

        public SetTelefoonNummer(string telefoonNummer)
        {
            TelefoonNummer = telefoonNummer;
        }
    }
}
