using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Pakketvergelijker;

namespace WebAPI.Services
{
    public interface IAanvullendeVerzekeringRepository
    {
        public IEnumerable<AanvullendeVerzekering> GetAanvullendeVerzekeringen();
        public IEnumerable<PakketVergelijkerDTO> GetAanvullendeVerzekeringenVoorPakketvergelijker();

        public List<string> GetVergoedingen();


    }
}
