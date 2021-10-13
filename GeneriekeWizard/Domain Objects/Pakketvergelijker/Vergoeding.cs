using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WizardAPI.Entitites
{
    public class Vergoeding
    {
        public Vergoeding()
        {

        }
        public int PakketId { get; set; }
        public string TekstPakketVergelijker { get; set; }
        public string VergoedingsType { get; set; }
    }
}
