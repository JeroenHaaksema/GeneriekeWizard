using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling
{
    public class GezinssamenstellingState
    {
        public List<Persoon> personen { get; }

        public GezinssamenstellingState(List<Persoon> personen)
        {
            this.personen = personen;
        }
    }
}
