using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens
{
    public class SetTussenvoegsel
    {
        public int persoonId { get; set; }
        public string tussenvoegsel { get; set; }
        public SetTussenvoegsel(int persoonId, string tussenvoegsel)
        {
            this.persoonId = persoonId;
            this.tussenvoegsel = tussenvoegsel;
        }
    }
}
