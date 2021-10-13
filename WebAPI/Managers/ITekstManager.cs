using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;

namespace WebAPI.Managers
{
    public interface ITekstManager
    {
        public List<KeuzehulpTekstblok> GetKeuzehulpTekstBlokken();

        public VerzekeringTekstenDTO GetVerzekeringTeksten();
        public List<AanvullendeverzekeringTekst> GetAanvullendeVerzekeringen();
        public List<BasisverzekeringTekst> GetBasisVerzekeringen();
        public List<TandverzekeringTekst> GetTandverzekeringen();
    }
}
