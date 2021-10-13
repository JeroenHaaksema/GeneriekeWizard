using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind
{
    public class UpdateEigenRisicoKind
    {
        public List<int> persoonIds { get; }

        public UpdateEigenRisicoKind(List<int> persoonIds)
        {
            this.persoonIds = persoonIds;
        }
    }
}
