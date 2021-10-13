using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens
{
    public class SetAchternaam
    {
        public int persoonId { get; set; }
        public string achternaam { get; set; }
        public SetAchternaam(int persoonId, string achternaam)
        {
            this.persoonId = persoonId;
            this.achternaam = achternaam;
        }
    }
}
