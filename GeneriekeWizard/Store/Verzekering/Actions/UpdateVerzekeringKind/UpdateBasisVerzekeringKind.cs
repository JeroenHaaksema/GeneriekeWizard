using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind
{
    public class UpdateBasisVerzekeringKind
    {
        public List<int> persoonIds { get; }

        public UpdateBasisVerzekeringKind(List<int> persoonIds)
        {
            this.persoonIds = persoonIds;
        }
    }
}
