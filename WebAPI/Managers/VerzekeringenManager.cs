using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;
using WebAPI.Services;

namespace WebAPI.Managers
{
    public class VerzekeringenManager : IVerzekeringenManager
    {
        private readonly IVerzekeringenRepository _verzekeringenRepository;
        public VerzekeringenManager(IVerzekeringenRepository verzekeringenRepository)
        {
            _verzekeringenRepository = verzekeringenRepository;
        }
        public List<Aanvullendeverzekering> GetAanvullendeverzekeringen()
        {
            return _verzekeringenRepository.GetAanvullendeverzekeringen();
        }

        public List<Basisverzekering> GetBasisverzekeringen()
        {
            return _verzekeringenRepository.GetBasisverzekeringen();
        }

        public List<Tandverzekering> GetTandverzekeringen()
        {
            return _verzekeringenRepository.GetTandverzekeringen();
        }
    }
}
