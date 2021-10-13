using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.GeslachtEnum;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens
{
    public class SetGeslacht
    {
        public int persoonId { get; set; }
        public Geslacht geslacht { get; set; }
        public SetGeslacht(int persoonId, Geslacht geslacht)
        {
            this.persoonId = persoonId;
            this.geslacht = geslacht;
        }
    }
}
