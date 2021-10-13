using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Pakketvergelijker;
using WebAPI.Services;

namespace WebAPI.Managers
{
    public class AanvullendeVerzekeringManager : IAanvullendeVerzekeringManager
    {
        private readonly IAanvullendeVerzekeringRepository _aanvullendeVerzekeringRepository;

        public AanvullendeVerzekeringManager(IAanvullendeVerzekeringRepository aanvullendeVerzekeringRepository)
        {
            _aanvullendeVerzekeringRepository = aanvullendeVerzekeringRepository;
        }
        public List<string> GetVergoedingen()
        {
            return _aanvullendeVerzekeringRepository.GetVergoedingen();
        }

        IEnumerable<AanvullendeVerzekering> IAanvullendeVerzekeringManager.GetAanvullendeVerzekeringen()
        {
            return _aanvullendeVerzekeringRepository.GetAanvullendeVerzekeringen();
        }

        IEnumerable<PakketVergelijkerDTO> IAanvullendeVerzekeringManager.GetAanvullendeVerzekeringenVoorPakketvergelijker()
        {
            return _aanvullendeVerzekeringRepository.GetAanvullendeVerzekeringenVoorPakketvergelijker();
        }
    }
}
