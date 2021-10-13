using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringKind
{
    public class SetTandVerzekeringKind
    {
        public int persoonId { get; set; }

        public SetTandVerzekeringKind(int persoonId)
        {
            this.persoonId = persoonId;
        }
    }
}
