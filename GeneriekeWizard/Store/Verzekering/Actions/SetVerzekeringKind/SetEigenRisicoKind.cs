using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringKind
{
    public class SetEigenRisicoKind
    {
        public int persoonId { get; set; }

        public SetEigenRisicoKind(int persoonId)
        {
            this.persoonId = persoonId;
        }
    }
}
