using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{
    public class VerzekeringDTO
    {
        public VerzekeringDTO()
        {

        }

        public VerzekeringDTO(List<Aanvullendeverzekering> aanvullendeverzekeringen, List<Basisverzekering> basisverzekeringen, List<Tandverzekering> tandverzekeringen)
        {
            this.aanvullendeVerzekeringen = aanvullendeverzekeringen;
            this.basisVerzekeringen = basisverzekeringen;
            this.tandVerzekeringen = tandverzekeringen;
        }

        public List<Aanvullendeverzekering> aanvullendeVerzekeringen { get; set; }
        public List<Basisverzekering> basisVerzekeringen { get; set; }
        public List<Tandverzekering> tandVerzekeringen { get; set; }
    }
}
