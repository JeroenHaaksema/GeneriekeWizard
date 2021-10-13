using Fluxor;
using GeneriekeWizard.Services;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizardAPI.Models;

namespace GeneriekeWizard.Pages.Pakketvergelijker
{
    public partial class Pakketvergelijker
    {
        [Inject]
        WizardAPIService _wizardAPIService { get; set; }
        [Inject]
        private NavigationManager _navigationManager { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Parameter]
        public string PakketType { get; set; }
        private List<PakketVergelijkerDTO> tandPakketten { get; set; }
        private List<PakketVergelijkerDTO> aanvullendePakketten { get; set; }

        private List<string> tandVergoedingen { get; set; }

        private List<string> aanvullendeVergoedingen { get; set; }

        private List<string> VergoedingenOverzicht { get; set; }
        public Pakketvergelijker()
        {

        }

        public Pakketvergelijker(WizardAPIService wizardAPIService)
        {
            _wizardAPIService = wizardAPIService;
        }

        protected override async Task OnInitializedAsync()
        {
            aanvullendePakketten = await _wizardAPIService.GetAsync<List<PakketVergelijkerDTO>>("api/pakketvergelijker/aanvullendeverzekeringen");
            aanvullendeVergoedingen = (await _wizardAPIService.GetAsync<List<string>>("api/pakketvergelijker/aanvullendevergoedingen"));
            tandPakketten = await _wizardAPIService.GetAsync<List<PakketVergelijkerDTO>>("api/pakketvergelijker/tandverzekeringen");
            tandVergoedingen = (await _wizardAPIService.GetAsync<List<string>>("api/pakketvergelijker/tandvergoedingen"));
            VergoedingenOverzicht = new List<string>();

            base.OnInitialized();
        }

        private Boolean DataIsOpgehaald()
        {
            return (aanvullendePakketten != null || tandPakketten != null);
        }


        private void VoegVergoedingToeAanOverzicht(string vergoeding)
        {
            VergoedingenOverzicht.Add(vergoeding);
        }

        private void VerwijderVergoedingUitOverzicht(string vergoeding)
        {
            VergoedingenOverzicht.Remove(vergoeding);
        }

        private Boolean VergoedingInOverzicht(string vergoeding)
        {
            return VergoedingenOverzicht.Contains(vergoeding);
        }

        private void Sluiten()
        {
            _navigationManager.NavigateTo("stap2");
        }
    }
}
