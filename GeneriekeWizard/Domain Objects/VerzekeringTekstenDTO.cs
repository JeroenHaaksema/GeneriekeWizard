using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{

    public class VerzekeringTekstenDTO
    {
        public VerzekeringTekstenDTO()
        {

        }

        public VerzekeringTekstenDTO(List<AanvullendeverzekeringTekst> aanvullendeverzekeringen, List<BasisverzekeringTekst> basisverzekeringen, List<TandverzekeringTekst> tandverzekeringen)
        {
            this.aanvullendeVerzekeringen = aanvullendeverzekeringen;
            this.basisVerzekeringen = basisverzekeringen;
            this.tandVerzekeringen = tandverzekeringen;
        }

        public List<AanvullendeverzekeringTekst> aanvullendeVerzekeringen { get; set; }
        public List<BasisverzekeringTekst> basisVerzekeringen { get; set; }
        public List<TandverzekeringTekst> tandVerzekeringen { get; set; }
    }
}
