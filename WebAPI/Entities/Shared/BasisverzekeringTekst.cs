using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entities.Shared
{
    public class BasisverzekeringTekst : VerzekeringTekst
    {
        public BasisverzekeringTekst()
        {
        }

        public BasisverzekeringTekst(int id, string naam, string tekst, int prijs) : base(id, naam, tekst, prijs)
        {
        }
    }
}
