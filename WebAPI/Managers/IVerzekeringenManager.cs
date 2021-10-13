using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;

namespace WebAPI.Managers
{
    public interface IVerzekeringenManager
    {
        public List<Basisverzekering> GetBasisverzekeringen();
        public List<Tandverzekering> GetTandverzekeringen();
        public List<Aanvullendeverzekering> GetAanvullendeverzekeringen();
    }

}
