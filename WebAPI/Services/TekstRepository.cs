using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.Shared;

namespace WebAPI.Services
{
    public class TekstRepository : ITekstRepository
    {
        private List<KeuzehulpTekstblok> keuzehulpTekstBlokken;

        private List<AanvullendeverzekeringTekst> aanvullendeVerzekeringenTekstblokken;

        private List<BasisverzekeringTekst> basisVerzekeringenTekstblokken;

        private List<TandverzekeringTekst> tandVerzekeringenTekstblokken;


        public TekstRepository()
        {
            keuzehulpTekstBlokken = new List<KeuzehulpTekstblok>()
            {
                new KeuzehulpTekstblok { titel="Pakketvergelijker", tekst="In de module Pakketvergelijker kunt op basis van vergoedingen en behandelingen pakketen vergelijken.",
                    paginaNaam="pakketvergelijker/aanvullend", weergaveNaam="Klik hier om onze aanvullende verzekeringen te vergelijken"},
                new KeuzehulpTekstblok { titel="Pakketvergelijker", tekst="In de module Pakketvergelijker kunt op basis van vergoedingen en behandelingen pakketen vergelijken.",
                    paginaNaam="pakketvergelijker/tand", weergaveNaam="Klik hier om onze tand verzekeringen te vergelijken"},
                 new KeuzehulpTekstblok { titel="Help mij kiezen", tekst="In de module Help Mij Kiezen kunt op basis van vergoedingen en behandelingen pakketen vergelijken.",
                    paginaNaam="helpmijkiezen", weergaveNaam="Klik hier om Help Mij Kiezen te starten"},
            };

            aanvullendeVerzekeringenTekstblokken = new List<AanvullendeverzekeringTekst>()
            {
                new AanvullendeverzekeringTekst { id=1, naam ="Basis Keuze", tekst="Meer blabla", prijs=11 },
                new AanvullendeverzekeringTekst { id=2, naam ="Ruime Keuze", tekst="Meer blabla", prijs=13 },
                new AanvullendeverzekeringTekst { id=3, naam ="Ruimste Keuze", tekst="Meer blabla", prijs=17 },

            };

            basisVerzekeringenTekstblokken = new List<BasisverzekeringTekst>()
            {
                new BasisverzekeringTekst { id=1, naam ="Basis Keuze", tekst="Meer blabla", prijs=120 },
                new BasisverzekeringTekst { id=2, naam ="Eigen Keuze", tekst="Meer blabla", prijs=125 },
                new BasisverzekeringTekst { id=3, naam ="Ruime Keuze", tekst="Meer blabla", prijs=130 },
            };

            tandVerzekeringenTekstblokken = new List<TandverzekeringTekst>()
            {
                new TandverzekeringTekst { id=1, naam ="Tand Instap", tekst="Meer blabla", prijs=9 },
                new TandverzekeringTekst { id=2, naam ="Tand Ruim", tekst="Meer blabla", prijs=11 },
                new TandverzekeringTekst { id=3, naam ="Tand Extra", tekst="Meer blabla", prijs=14 },
            };

        }
        public List<KeuzehulpTekstblok> GetKeuzehulpTekstBlokken()
        {
            return keuzehulpTekstBlokken;
        }

        public List<AanvullendeverzekeringTekst> GetAanvullendeVerzekeringen()
        {
            return aanvullendeVerzekeringenTekstblokken;
        }

        public List<BasisverzekeringTekst> GetBasisVerzekeringen()
        {
            return basisVerzekeringenTekstblokken;
        }

        public List<TandverzekeringTekst> GetTandverzekeringen()
        {
            return tandVerzekeringenTekstblokken;
        }
    }
}
