using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene
{
    public class SetBasisVerzekering
    {
        public int persoonId { get; }
        public Basisverzekering basisVerzekering { get; }
        public SetBasisVerzekering(int persoonId, Basisverzekering basisverzekering)
        {
            this.persoonId = persoonId;
            this.basisVerzekering = basisverzekering;
        }
    }
}
