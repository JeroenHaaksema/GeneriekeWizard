using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Pakketvergelijker;
using WebAPI.Services;

namespace WebAPI.Managers
{
    public class TandVerzekeringManager : ITandVerzekeringManager
    {
        private readonly ITandVerzekeringRepository _tandVerzekeringRepository;

        public TandVerzekeringManager(ITandVerzekeringRepository tandVerzekeringRepository)
        {
            _tandVerzekeringRepository = tandVerzekeringRepository;
        }

        public IEnumerable<PakketVergelijkerDTO> GetAanvullendeVerzekeringenVoorPakketvergelijker()
        {
            return _tandVerzekeringRepository.GetAanvullendeVerzekeringenVoorPakketvergelijker();
        }

        public IEnumerable<TandVerzekering> GetTandVerzekeringen()
        {
            return _tandVerzekeringRepository.GetTandVerzekeringen();
        }

        public List<string> GetVergoedingen()
        {
            return _tandVerzekeringRepository.GetVergoedingen();
        }
    }
}
