using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizardAPI.Entitites;

namespace WizardAPI.Models
{
    public class PakketVergelijkerDTO
    {
        public PakketVergelijkerDTO()
        {

        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public string Code { get; set; }
        public string TekstPakketVergelijker { get; set; }
        public List<Vergoeding> Vergoedingen { get; set; }
    }
}
