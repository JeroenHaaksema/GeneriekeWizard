using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene
{
    public class SetTandVerzekering
    {
        public int persoonId { get; }
        public Tandverzekering tandVerzekering { get; }

        public SetTandVerzekering(int persoonId, Tandverzekering tandVerzekering)
        {
            this.persoonId = persoonId;
            this.tandVerzekering = tandVerzekering;
        }
    }
}
