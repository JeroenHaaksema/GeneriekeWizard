using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens
{
    public class SetBSN
    {
        public int persoonId { get; set; }
        public string BSN { get; set; }
        public SetBSN(int persoonId, string BSN)
        {
            this.persoonId = persoonId;
            this.BSN = BSN;
        }
    }
}
