using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entities.Shared
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
            this.tandverzekeringen = tandverzekeringen;
        }

        public List<AanvullendeverzekeringTekst> aanvullendeVerzekeringen { get; set; }
        public List<BasisverzekeringTekst> basisVerzekeringen { get; set; }
       public  List<TandverzekeringTekst> tandverzekeringen { get; set; }
    }
}
