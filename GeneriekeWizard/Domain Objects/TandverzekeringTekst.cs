using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{
    public class TandverzekeringTekst : VerzekeringTekst
    {
        public TandverzekeringTekst()
        {
        }

        public TandverzekeringTekst(int id, string naam, string tekst, int prijs) : base(id, naam, tekst, prijs)
        {
        }
    }
}
