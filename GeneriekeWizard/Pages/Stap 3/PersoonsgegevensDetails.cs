using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Services;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_3
{
    public partial class PersoonsgegevensDetails
    {

        [Parameter]
        public int persoonId { get; set; }

        public PersoonModel persoonModel = new PersoonModel();
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        private Persoon persoon { get; set; }
        private Boolean opgeslagen = false;
        public void HandleValidSubmit()
        {
            Dispatcher.Dispatch(new SetVoorletters(persoonId, persoonModel.Voorletters));
            Dispatcher.Dispatch(new SetTussenvoegsel(persoonId, persoonModel.Tussenvoegsel));
            Dispatcher.Dispatch(new SetAchternaam(persoonId, persoonModel.Achternaam));
            Dispatcher.Dispatch(new SetBSN(persoonId, persoonModel.BSN));
            Dispatcher.Dispatch(new SetGeslacht(persoonId, persoonModel.Geslacht));
            opgeslagen = true;
        }

        public void SetPersoonsgegevens(int persoonId)
        {
            persoon = gezinssamenstellingState.Value.personen.Find(x => x.id == persoonId);
            if (persoon.voorletters != null)
            {
                persoonModel.Voorletters = persoon.voorletters;
            }
            if (persoon.tussenvoegsel != null)
            {
                persoonModel.Tussenvoegsel = persoon.tussenvoegsel;
            }
            if (persoon.achternaam != null)
            {
                persoonModel.Achternaam = persoon.achternaam;
            }
            if (persoon.bsn != null)
            {
                persoonModel.BSN = persoon.bsn;
            }
            if (persoon.geslacht != null)
            {
                persoonModel.Geslacht = persoon.geslacht;
            }

        }

        protected override void OnInitialized()
        {
            SetPersoonsgegevens(persoonId);
            base.OnInitialized();
        }
    }
}
