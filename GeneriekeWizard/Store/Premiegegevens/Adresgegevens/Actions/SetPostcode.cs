using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions
{
    public class SetPostcode
{

        public string Postcode { get; set; }

        public SetPostcode(string postcode)
        {
            Postcode = postcode;
        }
}
}
