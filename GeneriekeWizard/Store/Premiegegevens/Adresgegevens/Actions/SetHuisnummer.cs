using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions
{
    public class SetHuisnummer
{
        public int Huisnummer { get; set; }

        public SetHuisnummer(int huisnummer)
        {
            Huisnummer = huisnummer;
        }
}
}
