using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Pakketvergelijker;

namespace WebAPI.Services
{
    public class AanvullendeVerzekeringRepository : IAanvullendeVerzekeringRepository
    {
        public List<AanvullendeVerzekering> AanvullendeVerzekeringen;

        public AanvullendeVerzekeringRepository()
        {
            AanvullendeVerzekeringen = new List<AanvullendeVerzekering>()
            {
                new AanvullendeVerzekering { Id = 1, Code = "AVA", Naam = "Eigen keuze", Prijs = 10, TekstWizard = "Eigen keuze is ons instappakket", TekstPakketVergelijker = "Eigen keuze is ons instappakket", Vergoedingen = new List<Vergoeding>() {
                    new Vergoeding { PakketId= 1, TekstPakketVergelijker="Vergoeding tot 6 behandelingen bij aangesloten collectieven", VergoedingsType = "Fysiotherapie"},
                    new Vergoeding { PakketId= 1, TekstPakketVergelijker="Vergoeding tot 6 behandelingen bij aangesloten collectieven", VergoedingsType = "Kraamzorg"},
                }
                },
                 new AanvullendeVerzekering { Id = 2, Code = "AVB", Naam = "Ruime keuze", Prijs = 12, TekstWizard = "Ruime keuze biedt een ruimer aanbod aan plekken waar zorg te kiezen is ", TekstPakketVergelijker = "Ruime keuze biedt een ruimer aanbod aan plekken waar zorg te kiezen is", Vergoedingen = new List<Vergoeding>() {
                    new Vergoeding { PakketId= 2, TekstPakketVergelijker="Vergoeding tot 8 behandelingen bij alle collectieven", VergoedingsType = "Fysiotherapie"},
                    new Vergoeding { PakketId= 2, TekstPakketVergelijker="Vergoeding tot 8 behandelingen bij alle collectieven", VergoedingsType = "Kraamzorg"},
                }
                }, new AanvullendeVerzekering { Id = 3, Code = "AVC", Naam = "Vrije keuze", Prijs = 16, TekstWizard = "Vrije keuze laat u vrij in waar u zorg kiest", TekstPakketVergelijker = "Vrije keuze laat u vrij in waar u zorg kiest", Vergoedingen = new List<Vergoeding>() {
                    new Vergoeding { PakketId= 1, TekstPakketVergelijker="Vergoeding tot 10 behandelingen bij alle zorgaanbieders", VergoedingsType = "Fysiotherapie"},
                    new Vergoeding { PakketId= 1, TekstPakketVergelijker="Vergoeding tot 12 behandelingen bij alle zorgaanbieders", VergoedingsType = "Kraamzorg"},
                }
                },
            };
        }
        public IEnumerable<AanvullendeVerzekering> GetAanvullendeVerzekeringen()
        {
                return AanvullendeVerzekeringen;
        }
        public List<string> GetVergoedingen()
        {
            List<string> vergoedingen = new List<string>()
            {
                "Fysiotherapie",
                "Kraamzorg"
            };
            return vergoedingen;
        }

        IEnumerable<PakketVergelijkerDTO> IAanvullendeVerzekeringRepository.GetAanvullendeVerzekeringenVoorPakketvergelijker()
        {
            List<PakketVergelijkerDTO> pakketVergelijker = new List<PakketVergelijkerDTO>();
            foreach (var verzekering in AanvullendeVerzekeringen)
            {
                pakketVergelijker.Add(
                    new PakketVergelijkerDTO { Id = verzekering.Id, Code = verzekering.Code, Naam = verzekering.Naam, Prijs = verzekering.Prijs, TekstPakketVergelijker = verzekering.TekstPakketVergelijker, Vergoedingen = verzekering.Vergoedingen }
                    );
            }
            return pakketVergelijker;
        }
    }
}
