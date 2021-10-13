using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind
{
    public class UpdateAanvullendeVerzekeringKind
    {
        public List<int> persoonIds { get; }

        public UpdateAanvullendeVerzekeringKind(List<int> persoonIds)
        {
            this.persoonIds = persoonIds;
        }

    }
}
