using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.Delete
{
    public class DeleteTandVerzekering
    {
        public int persoonId { get; }

        public DeleteTandVerzekering(int persoonId)
        {
            this.persoonId = persoonId;
        }
    }
}
