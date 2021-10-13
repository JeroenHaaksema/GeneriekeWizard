using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;
using WebAPI.Services;

namespace WebAPI.Managers
{
    public class TekstManager : ITekstManager
    {
        private readonly ITekstRepository _tekstRepository;

        public TekstManager(ITekstRepository tekstRepository)
        {
            _tekstRepository = tekstRepository;
        }

        public List<AanvullendeverzekeringTekst> GetAanvullendeVerzekeringen()
        {
            return _tekstRepository.GetAanvullendeVerzekeringen();
        }

        public List<BasisverzekeringTekst> GetBasisVerzekeringen()
        {
            return _tekstRepository.GetBasisVerzekeringen();
        }

        public List<KeuzehulpTekstblok> GetKeuzehulpTekstBlokken()
        {
            return _tekstRepository.GetKeuzehulpTekstBlokken();
        }

        public List<TandverzekeringTekst> GetTandverzekeringen()
        {
            return _tekstRepository.GetTandverzekeringen();
        }

        public VerzekeringTekstenDTO GetVerzekeringTeksten()
        {
            return new VerzekeringTekstenDTO(_tekstRepository.GetAanvullendeVerzekeringen(), GetBasisVerzekeringen(), GetTandverzekeringen());
        }
    }
}
