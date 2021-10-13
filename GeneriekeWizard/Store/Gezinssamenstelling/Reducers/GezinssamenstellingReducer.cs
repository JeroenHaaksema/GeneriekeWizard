using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling.Gezinssamenstelling.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Reducers
{
    public class GezinssamenstellingReducer
    {

        [ReducerMethod]
        public static GezinssamenstellingState AddVolwasseneAction(GezinssamenstellingState state, VoegVolwasseneToe action)
        {
            List<Persoon> personen = state.personen;
            int id = personen.Select(t => t.id).Max() + 1;
            Persoon persoon = new Persoon(id, VerzekerdeType.Medeverzekerde);
            personen.Add(persoon);

            personen = sorteerPersonen(personen);

            return new GezinssamenstellingState(
                personen: personen
                );
        }

        [ReducerMethod]
        public static GezinssamenstellingState VerwijderVolwasseneAction(GezinssamenstellingState state, VerwijderVolwassene action)
        {
            List<Persoon> personen = state.personen;
            int hoogsteId = VindHoogsteId(personen.Where(x => !x.IsKind()).ToList());

            Persoon laatstePersoon = personen.Find(x => x.id == hoogsteId);
            personen.Remove(laatstePersoon);

            personen = sorteerPersonen(personen);

            return new GezinssamenstellingState(
            personen: personen
            );
        }

        public static int VindHoogsteId(List<Persoon> personen)
        {
            int hoogsteId = 0;
            foreach (Persoon persoon in personen)
            {
                if (persoon.id > hoogsteId)
                {
                    hoogsteId = persoon.id;
                }
            }
            return hoogsteId;
        }

        [ReducerMethod]
        public static GezinssamenstellingState AddKindAction(GezinssamenstellingState state, VoegKindToe action)
        {
            List<Persoon> personen = state.personen;
            int id = personen.Select(t => t.id).Max() + 1;
            Persoon persoon = new Persoon(id, VerzekerdeType.Kind);
            personen.Add(persoon);
            personen = sorteerPersonen(personen);

            return new GezinssamenstellingState(
                personen: personen
                );
        }

        [ReducerMethod]
        public static GezinssamenstellingState VerwijderKindAction(GezinssamenstellingState state, VerwijderKind action)
        {
            List<Persoon> personen = state.personen;
            int hoogsteId = VindHoogsteId(personen.Where(x => x.IsKind()).ToList());

            Persoon laatstePersoon = personen.Find(x => x.id == hoogsteId);
            personen.Remove(laatstePersoon);

            personen = sorteerPersonen(personen);

            return new GezinssamenstellingState(
            personen: personen
            );
        }


        public static List<Persoon> sorteerPersonen(List<Persoon> personen)
        {
            return personen = personen
             .OrderBy(t => t.id)
             .OrderBy(t => t.verzekerdeType)
             .ToList();
        }
    }
}
