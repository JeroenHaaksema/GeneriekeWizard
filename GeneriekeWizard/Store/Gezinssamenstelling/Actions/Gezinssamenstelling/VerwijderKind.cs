using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Gezinssamenstelling.Actions
{
    public class VerwijderKind
    {
        public VerwijderKind()
        {

        }

        public VerwijderKind(int persoonsId)
        {
            this.persoonsId = persoonsId;
        }

        public int? persoonsId { get; }

    }
}
