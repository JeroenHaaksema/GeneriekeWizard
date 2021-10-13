using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;

namespace WebAPI.Services
{
    public class VerzekeringenRepository : IVerzekeringenRepository
    {
        private List<Basisverzekering> basisverzekeringen;
        private List<Tandverzekering> tandverzekeringen;
        private List<Aanvullendeverzekering> aanvullendeverzekeringen;

        public VerzekeringenRepository()
        {
            basisverzekeringen = new List<Basisverzekering>()
            {
                new Basisverzekering { id =1, naam ="Basis Keuze", prijs=120},
                new Basisverzekering { id =2, naam ="Eigen Keuze", prijs=125},
                new Basisverzekering { id =3, naam ="Ruime Keuze", prijs=130},
            };

            aanvullendeverzekeringen = new List<Aanvullendeverzekering>() {


                new Aanvullendeverzekering {id=1, naam="Basis Keuze", prijs=11},
                new Aanvullendeverzekering {id=2, naam="Ruime Keuze", prijs=13},
                new Aanvullendeverzekering {id=3, naam="Ruimste Keuze", prijs=17},
            };

            tandverzekeringen = new List<Tandverzekering>() {
                new Tandverzekering { id =1, naam="Tand Instap", prijs=9},
                new Tandverzekering { id =2, naam="Tand Ruim", prijs=11},
                new Tandverzekering { id =3, naam="Tand Extra", prijs=14},
            };
        }

        public List<Aanvullendeverzekering> GetAanvullendeverzekeringen()
        {
            return aanvullendeverzekeringen;
        }

        public List<Basisverzekering> GetBasisverzekeringen()
        {
            return basisverzekeringen;
        }

        public List<Tandverzekering> GetTandverzekeringen()
        {
            return tandverzekeringen;
        }
    
    }
}
