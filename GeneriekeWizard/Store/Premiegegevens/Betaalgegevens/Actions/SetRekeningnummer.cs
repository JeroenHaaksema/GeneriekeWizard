using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Actions
{
    public class SetRekeningnummer
{
        public string Rekeningnummer { get; set; }

        public SetRekeningnummer(string rekeningnummer)
        {
            Rekeningnummer = rekeningnummer;
        }
}
}
