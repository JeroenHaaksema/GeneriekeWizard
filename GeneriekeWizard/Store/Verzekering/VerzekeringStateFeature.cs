using Fluxor;
using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering
{
    public class VerzekeringStateFeature : Feature<VerzekeringState>
    {
        public override string GetName()
        {
            return "verzekering";
        }

        protected override VerzekeringState GetInitialState()
        {
            return new VerzekeringState(new List<PersoonVerzekering>());
        }
    }
}
