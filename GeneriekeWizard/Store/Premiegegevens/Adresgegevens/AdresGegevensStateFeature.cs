using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens
{
    public class AdresGegevensStateFeature : Feature<AdresGegevensState>
    {
        public override string GetName()
        {
            return "adresgegevens";
        }

        protected override AdresGegevensState GetInitialState()
        {
            AdresGegevensState adresGegevensState = new AdresGegevensState(null, null, 0,null); ;
            return adresGegevensState;
        }
    }
}
