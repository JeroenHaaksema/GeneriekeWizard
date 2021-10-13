using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entities.Pakketvergelijker
{
    public class AanvullendeVerzekering
    {

        public AanvullendeVerzekering()
        {

        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public string Code { get; set; }
        public string TekstWizard { get; set; }
        public string TekstPakketVergelijker { get; set; }
        public List<Vergoeding> Vergoedingen { get; set; }

    }
}
