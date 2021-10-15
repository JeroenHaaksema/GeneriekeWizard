using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Services;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Actions;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens.Actions;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.BetaaltermijnEnum;
using static GeneriekeWizard.Domain_Objects.BetaalTypeEnum;

namespace GeneriekeWizard.Pages.Stap_3
{
    public partial class Premiegegevens
    {

        public PremieGegevensModel premieGegevensModel = new PremieGegevensModel();
        protected List<Land> Landen;

        [Inject]
        private IState<AdresGegevensState> adresgegevensState { get; set; }
        [Inject]
        private IState<BetaalgegevensState> betaalgegevensState { get; set; }
        [Inject]
        private IState<ContactgegevensState> contactgegevensState { get; set; }
        [Inject]
        private NavigationManager _navigationManager { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        protected override void OnInitialized()
        {
            Landen = new List<Land>()
            {
            new Land { Id=1, Naam="Nederland"},
            new Land { Id=2, Naam="Belgie"},
            new Land { Id=3, Naam="Luxemburg"},
            };

            base.OnInitialized();
        }

        public void HandleValidSubmit()
        {
            //Adresgegevens
            Dispatcher.Dispatch(new SetHuisnummer(premieGegevensModel.Huisnummer));
            Dispatcher.Dispatch(new SetLand(Landen.Find(t => t.Id == premieGegevensModel.Land.Id)));
            Dispatcher.Dispatch(new SetPostcode(premieGegevensModel.Postcode));
            Dispatcher.Dispatch(new SetToevoeging(premieGegevensModel.Toevoeging));

            //Betaalgegevens
            Dispatcher.Dispatch(new SetBetaaltermijn(premieGegevensModel.BetaalTermijn));
            Dispatcher.Dispatch(new SetBetaaltype(premieGegevensModel.BetaalType));
            Dispatcher.Dispatch(new SetRekeningnummer(premieGegevensModel.RekeningNummer));

            //Contactgegevens
            Dispatcher.Dispatch(new SetEmailAdres(premieGegevensModel.EmailAdres));
            Dispatcher.Dispatch(new SetTelefoonNummer(premieGegevensModel.TelefoonNummer));

            _navigationManager.NavigateTo("/stap4");
        }
    }
}
