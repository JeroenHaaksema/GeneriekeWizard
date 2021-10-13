using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{
    public class Verzekering
    {

        public Verzekering()
        {

        }

        public Verzekering(int id, string naam, int prijs)
        {
            this.id = id;
            this.naam = naam;
            this.prijs = prijs;
        }

        public int id { get; set; }
        public string naam { get; set; }
        public int prijs { get; set; }

    }
}
