using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entities.Shared
{
    public class VerzekeringTekst
    {
        public VerzekeringTekst()
        {

        }

        public VerzekeringTekst(int id, string naam, string tekst, int prijs)
        {
            this.id = id;
            this.naam = naam;
            this.tekst = tekst;
            this.prijs = prijs;
        }

        public int id { get; set; }
        public string naam { get; set; }
        public string  tekst { get; set; }
        public int prijs { get; set; }
    }
}
