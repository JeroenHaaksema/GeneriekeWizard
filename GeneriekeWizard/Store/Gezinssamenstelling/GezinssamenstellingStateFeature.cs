using Fluxor;
using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling
{
    public class GezinssamenstellingStateFeature : Feature<GezinssamenstellingState>
    {
        public override string GetName()
        {
            return "gezinssamenstelling";
        }

        protected override GezinssamenstellingState GetInitialState()
        {
            List<Persoon> personen = new List<Persoon>();
            Persoon persoon = new Persoon(1, VerzekerdeType.Hoofdverzekerde);
            personen.Add(persoon);
            GezinssamenstellingState gezinssamenstelling = new GezinssamenstellingState(
                personen: personen);

            return gezinssamenstelling;
        }
    }
}
