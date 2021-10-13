using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringKind;
using GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Reducers
{
    public class KindVerzekeringReducer
    {

        [ReducerMethod]
        public static VerzekeringState SetEigenRisicoKind(VerzekeringState state, SetEigenRisicoKind action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            if (persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).eigenRisico = 0;
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }

        [ReducerMethod]
        public static VerzekeringState UpdateAanvullendeVerzekeringKind(VerzekeringState state, UpdateAanvullendeVerzekeringKind action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            foreach (int persoonId in action.persoonIds)
            {
                if (persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() > 0)
                {
                    persoonVerzekeringen.Find(x => x.persoonId == persoonId).aanvullendeverzekering = null;
                }
            }

            if (persoonVerzekeringen.FindAll(x => x.aanvullendeverzekering != null).Count() >= 1) { 
            Aanvullendeverzekering aanvullendeverzekering = new Aanvullendeverzekering();
            Aanvullendeverzekering temp = persoonVerzekeringen.FindAll(x => x.aanvullendeverzekering != null).OrderByDescending(x => x.aanvullendeverzekering.id).First().aanvullendeverzekering;
            aanvullendeverzekering.id = temp.id;
            aanvullendeverzekering.naam = temp.naam;
            aanvullendeverzekering.prijs = 0;

            foreach (int persoonId in action.persoonIds)
            {
                if (persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() > 0)
                {
                    persoonVerzekeringen.Find(x => x.persoonId == persoonId).aanvullendeverzekering = aanvullendeverzekering;
                }
                else
                {
                    PersoonVerzekering persoon = new PersoonVerzekering();
                    persoon.persoonId = persoonId;
                    persoon.aanvullendeverzekering = aanvullendeverzekering;
                    persoonVerzekeringen.Add(persoon);
                }
            }
            }
            return new VerzekeringState(
            persoonVerzekeringen: persoonVerzekeringen
            );
            }

        [ReducerMethod]
        public static VerzekeringState UpdateBasisVerzekeringKind(VerzekeringState state, UpdateBasisVerzekeringKind action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            foreach (int persoonId in action.persoonIds)
            {
                if (persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() > 0)
                {
                    persoonVerzekeringen.Find(x => x.persoonId == persoonId).basisverzekering = null;
                }
            }

            Basisverzekering basisverzekering = new Basisverzekering();
            Basisverzekering temp = persoonVerzekeringen.FindAll(x => x.basisverzekering != null).OrderByDescending(x => x.basisverzekering.id).First().basisverzekering;
            basisverzekering.id = temp.id;
            basisverzekering.naam = temp.naam;
            basisverzekering.prijs = 0;

            foreach (int persoonId in action.persoonIds)
            {
                if (persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() > 0)
                {
                    persoonVerzekeringen.Find(x => x.persoonId == persoonId).basisverzekering = basisverzekering;
                }
                else
                {
                    PersoonVerzekering persoon = new PersoonVerzekering();
                    persoon.persoonId = persoonId;
                    persoon.basisverzekering = basisverzekering;
                    persoonVerzekeringen.Add(persoon);
                }
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }

        [ReducerMethod]
        public static VerzekeringState UpdateTandVerzekeringKind(VerzekeringState state, UpdateTandVerzekeringKind action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            foreach (int persoonId in action.persoonIds)
            {
                if (persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() > 0)
                {
                    persoonVerzekeringen.Find(x => x.persoonId == persoonId).tandverzekering = null;
                }
            }

            if (persoonVerzekeringen.FindAll(x => x.tandverzekering != null).Count() >= 1)
            {
                Tandverzekering tandverzekering = new Tandverzekering();
                Tandverzekering temp = persoonVerzekeringen.FindAll(x => x.tandverzekering != null).OrderByDescending(x => x.tandverzekering.id).First().tandverzekering;
                tandverzekering.id = temp.id;
                tandverzekering.naam = temp.naam;
                tandverzekering.prijs = 0;


                foreach (int persoonId in action.persoonIds)
                {
                    if (persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() > 0)
                    {
                        persoonVerzekeringen.Find(x => x.persoonId == persoonId).tandverzekering = tandverzekering;
                    }
                    else
                    {
                        PersoonVerzekering persoon = new PersoonVerzekering();
                        persoon.persoonId = persoonId;
                        persoon.tandverzekering = tandverzekering;
                        persoonVerzekeringen.Add(persoon);
                    }
                }
            }
            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }
    }
}
