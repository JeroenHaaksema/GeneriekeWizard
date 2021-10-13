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
    public partial class TandverzekeringComponent
    {
        [Parameter]
        public List<TandverzekeringTekst> tandverzekeringsTeksten { get; set; }
        [Parameter]
        public List<Tandverzekering> tandverzekeringen { get; set; }
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void SelectTandVerzekering(int persoonId, int tandverzekeringId)
        {
            SelectTandVerzekeringVoorPersoon(persoonId, tandverzekeringId);
            UpdateTandVerzekeringVoorKinderen();
        }

        private void SelectTandVerzekeringVoorPersoon(int persoonId, int tandverzekeringId)
        {
            var action = new SetTandVerzekering(persoonId, tandverzekeringen.Find(x => x.id == tandverzekeringId));
            Dispatcher.Dispatch(action);
        }

        private void UpdateTandVerzekeringVoorKinderen()
        {
            List<int> kinderen = gezinssamenstellingState.Value.personen.FindAll(x => x.IsKind()).Select(x => x.id).ToList();
            if (kinderen != null)
            {
                    var action = new UpdateTandVerzekeringKind(kinderen);
                    Dispatcher.Dispatch(action);
            }
        }

        private void DeleteTandVerzekering(int persoonId)
        {
            DeleteTandVerzekeringVoorPersoon(persoonId);
            UpdateTandVerzekeringVoorKinderen();
        }

        private void DeleteTandVerzekeringVoorPersoon(int persoonId)
        {
            var action = new DeleteTandVerzekering(persoonId);
            Dispatcher.Dispatch(action);
        }

        private Boolean Geselecteerd(int persoonId, int tandverzekeringId)
        {


            if ((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.tandverzekering == null).Count() > 0) || 
                (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() <1))
            {
                return false;
            }
            if (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.tandverzekering.id != tandverzekeringId).Count() > 0)
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
