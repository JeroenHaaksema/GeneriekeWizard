using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.Delete
{
    public class DeleteAanvullendeVerzekering
    {
        public int persoonId { get; }

        public DeleteAanvullendeVerzekering(int persoonId)
        {
            this.persoonId = persoonId;
        }
    }
}
