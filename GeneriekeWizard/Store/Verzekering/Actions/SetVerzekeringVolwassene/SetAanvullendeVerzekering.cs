using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene
{
    public class SetAanvullendeVerzekering
    {
        public int persoonId { get; }
        public Aanvullendeverzekering aanvullendeVerzekering { get; }

        public SetAanvullendeVerzekering(int persoonId, Aanvullendeverzekering aanvullendeVerzekering)
        {
            this.persoonId = persoonId;
            this.aanvullendeVerzekering = aanvullendeVerzekering;
        }
    }
}
