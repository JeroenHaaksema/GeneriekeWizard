using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Pakketvergelijker;

namespace WebAPI.Services
{
    public class TandVerzekeringRepository : ITandVerzekeringRepository
    {
        List<TandVerzekering> TandVerzekeringen;
        public TandVerzekeringRepository()
        {
            TandVerzekeringen = new List<TandVerzekering>() {
                new TandVerzekering { Id=1, Code= "TVA", Naam="Tandvullend", Prijs=10, TekstWizard="Tandvullend is het instappakket", TekstPakketVergelijker="Tandvullend is het instappakket", Vergoedingen = new List<Vergoeding>()
                {
                    new Vergoeding { PakketId=1, VergoedingsType = "Mondzorg boven 18 jaar", TekstPakketVergelijker="Vergoeding tot €250 voor mondzorg bij aangesloten tandartsen"},
                    new Vergoeding { PakketId=1, VergoedingsType = "Mondzorg onder 18 jaar", TekstPakketVergelijker="Vergoeding tot €250 voor mondzorg bij aangesloten tandartsen"},
                    new Vergoeding { PakketId=1, VergoedingsType = "Orthodontie onder 18 jaar", TekstPakketVergelijker="Vergoeding tot €450 voor mondzorg bij aangesloten tandartsen"},
                }
                },
                new TandVerzekering { Id=2, Code= "TVB", Naam="Tandvullender", Prijs=13, TekstWizard="Tandvullender is ons middelste pakket", TekstPakketVergelijker="Tandvullender is ons middelste pakket", Vergoedingen = new List<Vergoeding>()
                {
                    new Vergoeding { PakketId=2, VergoedingsType = "Mondzorg boven 18 jaar", TekstPakketVergelijker="Vergoeding tot €350 voor mondzorg bij aangesloten tandartsen"},
                    new Vergoeding { PakketId=2, VergoedingsType = "Mondzorg onder 18 jaar", TekstPakketVergelijker="Vergoeding tot €350 voor mondzorg bij aangesloten tandartsen"},
                    new Vergoeding { PakketId=2, VergoedingsType = "Orthodontie onder 18 jaar", TekstPakketVergelijker="Vergoeding tot €500 voor mondzorg bij aangesloten tandartsen"},
                }
                },
                new TandVerzekering { Id=3, Code= "TVC", Naam="Tandvullendst", Prijs=19, TekstWizard="Tandvullendst is ons uitgebreidste pakket", TekstPakketVergelijker="Tandvullendst is ons uitgebreidste pakket", Vergoedingen = new List<Vergoeding>()
                {
                    new Vergoeding { PakketId=3, VergoedingsType = "Mondzorg boven 18 jaar", TekstPakketVergelijker="Vergoeding tot €500 voor mondzorg bij aangesloten tandartsen"},
                    new Vergoeding { PakketId=3, VergoedingsType = "Mondzorg onder 18 jaar", TekstPakketVergelijker="Vergoeding tot €650 voor mondzorg bij aangesloten tandartsen"},
                    new Vergoeding { PakketId=3, VergoedingsType = "Orthodontie onder 18 jaar", TekstPakketVergelijker="Vergoeding tot €600 voor mondzorg bij aangesloten tandartsen"},
                }
                }

            };
        }

        public IEnumerable<PakketVergelijkerDTO> GetAanvullendeVerzekeringenVoorPakketvergelijker()
        {
            List<PakketVergelijkerDTO> pakketVergelijker = new List<PakketVergelijkerDTO>();
            foreach (var verzekering in TandVerzekeringen)
            {
                pakketVergelijker.Add(
                    new PakketVergelijkerDTO { Id = verzekering.Id, Code = verzekering.Code, Naam = verzekering.Naam, Prijs = verzekering.Prijs, TekstPakketVergelijker = verzekering.TekstPakketVergelijker, Vergoedingen = verzekering.Vergoedingen }
                    );
            }
            return pakketVergelijker;
        }

        public IEnumerable<TandVerzekering> GetTandVerzekeringen()
        {
            return TandVerzekeringen;
        }

        public List<string> GetVergoedingen()
        {
            List<string> vergoedingen = new List<string>()
            {
                "Mondzorg boven 18 jaar",
                "Mondzorg onder 18 jaar",
                "Orthodontie onder 18 jaar"
            };
            return vergoedingen;
        }
    }
}
