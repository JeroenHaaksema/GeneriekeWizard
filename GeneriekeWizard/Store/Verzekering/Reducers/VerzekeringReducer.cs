using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Verzekering.Actions;
using GeneriekeWizard.Store.Verzekering.Actions.Delete;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Reducers
{
    public class VerzekeringReducer
    {
        [ReducerMethod]
        public static VerzekeringState SetEigenRisico(VerzekeringState state, SetEigenRisico action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            Boolean bestaat = persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0;
            if (bestaat)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).eigenRisico = action.eigenRisico;
            }
            else
            {
                PersoonVerzekering persoonVerzekering = new PersoonVerzekering();
                persoonVerzekering.persoonId = action.persoonId;
                persoonVerzekering.eigenRisico = action.eigenRisico;
                persoonVerzekeringen.Add(persoonVerzekering);
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }

        [ReducerMethod]
        public static VerzekeringState SetAanvullendeVerzekeringAction(VerzekeringState state, SetAanvullendeVerzekering action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            Boolean bestaat = persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0;
            if (bestaat)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).aanvullendeverzekering = action.aanvullendeVerzekering;
            }
            else
            {
                PersoonVerzekering persoonVerzekering = new PersoonVerzekering();
                persoonVerzekering.persoonId = action.persoonId;
                persoonVerzekering.aanvullendeverzekering = action.aanvullendeVerzekering;
                persoonVerzekeringen.Add(persoonVerzekering);
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }

        

        [ReducerMethod]
        public static VerzekeringState DeleteAanvullendeVerzekeringAction(VerzekeringState state, DeleteAanvullendeVerzekering action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            Boolean bestaat = persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0;
            if (bestaat)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).aanvullendeverzekering = null;
            }
            return new VerzekeringState(
            persoonVerzekeringen: persoonVerzekeringen
            );
        }

        [ReducerMethod]
        public static VerzekeringState SetBasisVerzekeringAction(VerzekeringState state, SetBasisVerzekering action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            Boolean bestaat = persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0;
            if (bestaat)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).basisverzekering = action.basisVerzekering;
            }
            else
            {
                PersoonVerzekering persoonVerzekering = new PersoonVerzekering();
                persoonVerzekering.persoonId = action.persoonId;
                persoonVerzekering.basisverzekering = action.basisVerzekering;
                persoonVerzekeringen.Add(persoonVerzekering);
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }


        [ReducerMethod]
        public static VerzekeringState SetTandVerzekeringAction(VerzekeringState state, SetTandVerzekering action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            Boolean bestaat = persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0;
            if (bestaat)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).tandverzekering = action.tandVerzekering;
            }
            else
            {
                PersoonVerzekering persoonVerzekering = new PersoonVerzekering();
                persoonVerzekering.persoonId = action.persoonId;
                persoonVerzekering.tandverzekering = action.tandVerzekering;
                persoonVerzekeringen.Add(persoonVerzekering);
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }

        [ReducerMethod]
        public static VerzekeringState DeleteTandVerzekeringAction(VerzekeringState state, DeleteTandVerzekering action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            Boolean bestaat = persoonVerzekeringen.FindAll(x => x.persoonId == action.persoonId).Count() > 0;
            if (bestaat)
            {
                persoonVerzekeringen.Find(x => x.persoonId == action.persoonId).tandverzekering = null;
            }

            return new VerzekeringState(
             persoonVerzekeringen: persoonVerzekeringen
             );
        }

        [ReducerMethod]
        public static VerzekeringState DeletePersoonAction(VerzekeringState state, DeletePersoon action)
        {
            List<PersoonVerzekering> persoonVerzekeringen = state.persoonVerzekeringen.ToList();
            PersoonVerzekering persoon = persoonVerzekeringen.Find(x => x.persoonId == action.persoonId);
            if (persoon != null)
            {
                persoonVerzekeringen.Remove(persoon);
            }

            return new VerzekeringState(
            persoonVerzekeringen: persoonVerzekeringen
            );
        }
    }
}
