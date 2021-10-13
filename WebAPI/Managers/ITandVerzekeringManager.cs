using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Pakketvergelijker;

namespace WebAPI.Managers
{
    public interface ITandVerzekeringManager
    {
        public IEnumerable<TandVerzekering> GetTandVerzekeringen();

        public IEnumerable<PakketVergelijkerDTO> GetAanvullendeVerzekeringenVoorPakketvergelijker();
        public List<string> GetVergoedingen();


    }
}
