using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.Delete
{
    public class DeletePersoon
    {
        public int persoonId { get; }

        public DeletePersoon(int persoonId)
        {
            this.persoonId = persoonId;
        }
    }
}
