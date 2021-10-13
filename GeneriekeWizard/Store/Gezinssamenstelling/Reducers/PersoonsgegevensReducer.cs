using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Reducers
{
    public class PersoonsgegevensReducer
    {
        [ReducerMethod]
        public static GezinssamenstellingState SetVoorlettersAction(GezinssamenstellingState state, SetVoorletters action)
        {
            List<Persoon> personen = state.personen;
            personen.Find(t => t.id == action.persoonId).voorletters = action.voorletters;

            return new GezinssamenstellingState(
                personen: personen
                );
        }

        [ReducerMethod]
        public static GezinssamenstellingState SetAchternaamAction(GezinssamenstellingState state, SetAchternaam action)
        {
            List<Persoon> personen = state.personen;
            personen.Find(t => t.id == action.persoonId).achternaam = action.achternaam;

            return new GezinssamenstellingState(
                personen: personen
                );
        }
        [ReducerMethod]
        public static GezinssamenstellingState SetTussenvoegselAction(GezinssamenstellingState state, SetTussenvoegsel action)
        {
            List<Persoon> personen = state.personen;
            personen.Find(t => t.id == action.persoonId).tussenvoegsel = action.tussenvoegsel;

            return new GezinssamenstellingState(
                personen: personen
                );
        }

        [ReducerMethod]
        public static GezinssamenstellingState SetBSNAction(GezinssamenstellingState state, SetBSN action)
        {
            List<Persoon> personen = state.personen;
            personen.Find(t => t.id == action.persoonId).bsn = action.BSN;

            return new GezinssamenstellingState(
                personen: personen
                );
        }

        [ReducerMethod]
        public static GezinssamenstellingState SetGeslachtAction(GezinssamenstellingState state, SetGeslacht action)
        {
            List<Persoon> personen = state.personen;
            personen.Find(t => t.id == action.persoonId).geslacht = action.geslacht;

            return new GezinssamenstellingState(
                personen: personen
                );
        }
    }
}
