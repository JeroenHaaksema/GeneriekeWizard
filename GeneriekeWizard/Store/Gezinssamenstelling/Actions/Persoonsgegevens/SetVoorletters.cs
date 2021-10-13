using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens
{
    public class SetVoorletters
    {
        public int persoonId { get; set; }
        public string voorletters { get; set; }
        public SetVoorletters(int persoonId, string voorletters)
        {
            this.persoonId = persoonId;
            this.voorletters = voorletters;
        }
    }
}
