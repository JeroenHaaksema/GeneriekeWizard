using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;

namespace WebAPI.Services
{
    public interface IVerzekeringenRepository
    {
        List<Basisverzekering> GetBasisverzekeringen();
        List<Tandverzekering> GetTandverzekeringen();
        List<Aanvullendeverzekering> GetAanvullendeverzekeringen();

    }
}
