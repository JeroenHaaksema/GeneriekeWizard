using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering
{
    public class VerzekeringState
    {
        public List<PersoonVerzekering> persoonVerzekeringen { get; }

        public VerzekeringState(List<PersoonVerzekering> persoonVerzekeringen)
        {
            this.persoonVerzekeringen = persoonVerzekeringen;
        }
    }
}
