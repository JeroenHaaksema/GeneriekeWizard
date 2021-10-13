using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Contactgegevens
{
    public class ContactgegevensStateFeature : Feature<ContactgegevensState>
    {
        public override string GetName()
        {
            return "contactgegevens";
        }

        protected override ContactgegevensState GetInitialState()
        {
            return new ContactgegevensState(null, null);
        }
    }
}
