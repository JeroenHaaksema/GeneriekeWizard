using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringKind
{
    public class SetAanvullendeVerzekeringKind
    {
        public int persoonId { get; set; }

        public SetAanvullendeVerzekeringKind(int persoonId)
        {
            this.persoonId = persoonId;
        }

    }
}
