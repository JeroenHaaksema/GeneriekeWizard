using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{
    public class VerstuurVerzekeringDTO
    {
        public VerstuurVerzekeringDTO(List<PersoonDTO> personen)
        {
            this.personen = personen;
        }
        List<PersoonDTO> personen { get; set; }

    }
}
