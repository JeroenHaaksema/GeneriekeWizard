using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.BetaaltermijnEnum;
using static GeneriekeWizard.Domain_Objects.BetaalTypeEnum;

namespace GeneriekeWizard.Store.Premiegegevens.Betaalgegevens
{
    public class BetaalgegevensStateFeature : Feature<BetaalgegevensState>
    {
        public override string GetName()
        {
            return "betaalgegevens";
        }

        protected override BetaalgegevensState GetInitialState()
        {
            return new BetaalgegevensState(
                null, Betaaltermijn.Maand , BetaalType.iDeal
                );
        }
    }
}
