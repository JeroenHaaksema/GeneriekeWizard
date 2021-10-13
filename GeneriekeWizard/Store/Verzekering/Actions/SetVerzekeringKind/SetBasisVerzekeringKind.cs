using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringKind
{
    public class SetBasisVerzekeringKind
    {
        public int persoonId { get; set; }

        public SetBasisVerzekeringKind(int persoonId)
        {
            this.persoonId = persoonId;
        }
    }
}
