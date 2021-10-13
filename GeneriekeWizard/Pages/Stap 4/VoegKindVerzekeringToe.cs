using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using GeneriekeWizard.Store.Verzekering.Actions;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_4
{
    public class VoegKindVerzekeringToe
    {
        /* 
        [Inject]
        public IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        public IState<VerzekeringState> verzekeringState { get; set; }
        public IDispatcher Dispatcher { get; set; }

        public List<Persoon> volwasennen { get; set; } = new List<Persoon>();
        public List<Persoon> kinderen { get; set; } = new List<Persoon>();
        private List<PersoonVerzekering> verzekerden { get; set; }

        public VoegKindVerzekeringToe()
        {

        }

        public void VulLijsten()
        {
            var test = verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == 1);

            foreach (Persoon persoon in gezinssamenstellingState.Value.personen)
            {
                if (!persoon.IsKind())
                {
                    volwasennen.Add(persoon);
                }
                else
                {
                    kinderen.Add(persoon);
                }
            }

            foreach (Persoon volwassene in volwasennen)
            {
                PersoonVerzekering persoon = verzekeringState.Value.persoonVerzekeringen.Find(x => x.persoonId == volwassene.id);
                if (persoon != null)
                {
                    verzekerden.Add(persoon);
                }

            }
        }
        public void GeefKinderenPakketten()
        {
            Basisverzekering basisverzekering = VindHoogsteBasisverzekering(verzekerden);
            Tandverzekering tandverzekering = VindHoogsteTandverzekering(verzekerden);
            Aanvullendeverzekering aanvullendeverzekering = VindHoogsteAanvullendeverzekering(verzekerden);
            foreach (Persoon kind in kinderen)
            {
                StelPakkettenIn(kind, basisverzekering, aanvullendeverzekering, tandverzekering);
            }
        }

        private Basisverzekering VindHoogsteBasisverzekering(List<PersoonVerzekering> verzekerden)
        {
            Basisverzekering basisverzekering = new Basisverzekering();
            basisverzekering.id = 0;
            foreach (PersoonVerzekering verzekerde in verzekerden)
            {
                if (basisverzekering.id < verzekerde.basisverzekering.id)
                {
                    basisverzekering = verzekerde.basisverzekering;
                }
            }
            basisverzekering.prijs = 0;
            return basisverzekering;
        }

        private Tandverzekering VindHoogsteTandverzekering(List<PersoonVerzekering> verzekerden)
        {
            Tandverzekering tandverzekering = new Tandverzekering();
            tandverzekering.id = 0;
            foreach (PersoonVerzekering verzekerde in verzekerden)
            {
                if (tandverzekering.id < verzekerde.tandverzekering.id)
                {
                    tandverzekering = verzekerde.tandverzekering;
                }
            }
            tandverzekering.prijs = 0;
            return tandverzekering;
        }

        private Aanvullendeverzekering VindHoogsteAanvullendeverzekering(List<PersoonVerzekering> verzekerden)
        {
            Aanvullendeverzekering aanvullendeverzekering = new Aanvullendeverzekering();
            aanvullendeverzekering.id = 0;
            foreach (PersoonVerzekering verzekerde in verzekerden)
            {
                if (aanvullendeverzekering.id < verzekerde.aanvullendeverzekering.id)
                {
                    aanvullendeverzekering = verzekerde.aanvullendeverzekering;
                }
            }
            aanvullendeverzekering.prijs = 0;
            return aanvullendeverzekering;
        }

        private void StelPakkettenIn(Persoon kind, Basisverzekering basisverzekering, Aanvullendeverzekering aanvullendeverzekering, Tandverzekering tandverzekering)
        {
            SelectBasisVerzekeringVoorPersoon(kind.id, basisverzekering);
            SelectAanvullendeVerzekeringVoorPersoon(kind.id, aanvullendeverzekering);
            SelectTandVerzekeringVoorPersoon(kind.id, tandverzekering);
        }

        private void SelectBasisVerzekeringVoorPersoon(int persoonId, Basisverzekering basisverzekering)
        {
            var action = new SetBasisVerzekering(persoonId, basisverzekering);
            Dispatcher.Dispatch(action);
        }

        private void SelectAanvullendeVerzekeringVoorPersoon(int persoonId, Aanvullendeverzekering aanvullendeverzekering)
        {
            if (aanvullendeverzekering.id == 0)
            {
                return;
            }
            var action = new SetAanvullendeVerzekering(persoonId, aanvullendeverzekering);
            Dispatcher.Dispatch(action);
        }
        private void SelectTandVerzekeringVoorPersoon(int persoonId, Tandverzekering tandverzekering)
        {
            if (tandverzekering.id == 0)
            {
                return;
            }
            var action = new SetTandVerzekering(persoonId, tandverzekering);
            Dispatcher.Dispatch(action);
        }        */

    }
}
