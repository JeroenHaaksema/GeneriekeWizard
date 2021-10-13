using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using GeneriekeWizard.Store.Verzekering.Actions;
using GeneriekeWizard.Store.Verzekering.Actions.Delete;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_2.VerzekeringsComponenten
{
    public partial class AanvullendeVerzekeringComponent
    {
        [Parameter]
        public List<AanvullendeverzekeringTekst> aanvullendeverzekeringsTeksten { get; set; }
        [Parameter]
        public List<Aanvullendeverzekering> aanvullendeverzekeringen { get; set; }
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void SelectAanvullendeVerzekering(int persoonId, int aanvullendeverzekeringId)
        {
            SelectAanvullendeVerzekeringVoorPersoon(persoonId, aanvullendeverzekeringId);
            UpdateAanvullendeVerzekeringVoorKinderen();
        }

        private void SelectAanvullendeVerzekeringVoorPersoon(int persoonId, int aanvullendeverzekeringId)
        {
            var action = new SetAanvullendeVerzekering(persoonId, aanvullendeverzekeringen.Find(x => x.id == aanvullendeverzekeringId));
            Dispatcher.Dispatch(action);
        }

        private void UpdateAanvullendeVerzekeringVoorKinderen()
        {
            List<int> kinderen = gezinssamenstellingState.Value.personen.FindAll(x => x.IsKind()).Select(x => x.id).ToList();
            if (kinderen != null)
            {
                    var action = new UpdateAanvullendeVerzekeringKind(kinderen);
                    Dispatcher.Dispatch(action);
            }
        }


        private void DeleteAanvullendeVerzekering(int persoonId)
        {
            DeleteAanvullendeVerzekeringVoorPersoon(persoonId);
            UpdateAanvullendeVerzekeringVoorKinderen();
        }

        private void DeleteAanvullendeVerzekeringVoorPersoon(int persoonId)
        {
            var action = new DeleteAanvullendeVerzekering(persoonId);
            Dispatcher.Dispatch(action);
        }



        private Boolean Geselecteerd(int persoonId, int aanvullendeverzekeringId)
        {
            if ((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.aanvullendeverzekering == null).Count() > 0) ||
                (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() < 1))
            {
                return false;
            }
            if (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.aanvullendeverzekering.id != aanvullendeverzekeringId).Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
