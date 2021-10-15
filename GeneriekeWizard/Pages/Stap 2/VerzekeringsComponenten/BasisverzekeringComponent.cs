using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using GeneriekeWizard.Store.Verzekering.Actions;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_2.VerzekeringsComponenten
{
    public partial class BasisverzekeringComponent
    {
        [Parameter]
        public List<BasisverzekeringTekst> basisverzekeringsTeksten { get; set; }
        [Parameter]
        public List<Basisverzekering> basisverzekeringen { get; set; }
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        public void SelectBasisVerzekering(int persoonId, int basisverzekeringId)
        {
            SelectBasisVerzekeringVoorPersoon(persoonId, basisverzekeringId);
            UpdateBasisVerzekeringVoorKinderen();
        }



        private void SelectBasisVerzekeringVoorPersoon(int persoonId, int basisverzekeringId)
        {
            var action = new SetBasisVerzekering(persoonId, basisverzekeringen.Find(x => x.id == basisverzekeringId));
            Dispatcher.Dispatch(action);
        }

        private void UpdateBasisVerzekeringVoorKinderen()
        {
            List<int> kinderen = gezinssamenstellingState.Value.personen.FindAll(x => x.IsKind()).Select(x => x.id).ToList();
            if (kinderen != null)
            {
                var action = new UpdateBasisVerzekeringKind(kinderen);
                    Dispatcher.Dispatch(action);
            }
        }

        private Boolean Geselecteerd(int persoonId, int basisVerzekeringId)
        {


            if ((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.basisverzekering == null).Count() > 0) ||
                (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() < 1))
            {
                return false;
            }
            if (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.basisverzekering.id != basisVerzekeringId).Count() > 0)
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
