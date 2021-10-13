using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;

namespace WebAPI.Services
{
    public interface ITekstRepository
    {
        public List<KeuzehulpTekstblok> GetKeuzehulpTekstBlokken();

        public List<AanvullendeverzekeringTekst> GetAanvullendeVerzekeringen();
        public List<BasisverzekeringTekst> GetBasisVerzekeringen();
        public List<TandverzekeringTekst> GetTandverzekeringen();
    }
}
