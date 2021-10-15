using GeneriekeWizard.Domain_Objects.HelpMijKiezen;
using GeneriekeWizard.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.HelpMijKiezen
{
    public partial class HelpMijKiezen
    {
        private List<HelpMijKiezenDTO> HelpMijKiezenVragenEnAntwoorden;
        private List<KeyValuePair<string, int>> VraagEnAntwoord;
        [Inject]
        WizardAPIService _wizardAPIService { get; set; }
        [Inject]
        private NavigationManager _navigationManager { get; set; }

        public HelpMijKiezen()
        {

        }

        public HelpMijKiezen(WizardAPIService wizardAPIService)
        {
            _wizardAPIService = wizardAPIService;
        }


        protected override async Task OnInitializedAsync()
        {
            HelpMijKiezenVragenEnAntwoorden = new List<HelpMijKiezenDTO>();
            HelpMijKiezenVragenEnAntwoorden = await _wizardAPIService.GetAsync<List<HelpMijKiezenDTO>>("api/helpmijkiezen");

            base.OnInitialized();
            VraagEnAntwoord = new List<KeyValuePair<string, int>>();
        }

        private void setAntwoord(string naam, int antwoord)
        {
            if (AntwoordAlGegeven(naam))
            {
                if (IngevuldeAntwoord(naam, antwoord))
                {
                    VraagEnAntwoord.Remove(new KeyValuePair<string, int>(naam, antwoord));
                }
                else
                {
                    VraagEnAntwoord.Remove(new KeyValuePair<string, int>(naam, ZoekWaarde(naam)));
                }
            }
            KeyValuePair<string, int> keyValuePair = new KeyValuePair<string, int>(naam, antwoord);
            VraagEnAntwoord.Add(keyValuePair);
        }

        public string ZoekAdvies(string naam)
        {
            string advies = "Wij adviseren u het pakket ";
            int vergoeding = ZoekWaarde(naam);
            foreach (var VraagEnAntwoord in HelpMijKiezenVragenEnAntwoorden)
            {
                if (VraagEnAntwoord.naam == naam)
                {
                    foreach (var PakketAntwoord in VraagEnAntwoord.pakketBijAntwoord)
                    {
                        if (PakketAntwoord.Key == vergoeding)
                        {
                            advies += PakketAntwoord.Value + ". Dit geeft u recht op " + PakketAntwoord.Key.ToString() + " " + VraagEnAntwoord.eenheid;
                        }
                    }
                }
            }
            return advies;
        }

        private int ZoekWaarde(string naam)
        {
            int antwoord = 0;
            foreach (var VenA in VraagEnAntwoord)
            {
                if (VenA.Key == naam)
                {
                    antwoord = VenA.Value;
                }
            }
            return antwoord;
        }

        private Boolean VraagBeantwoord(string naam)
        {
            foreach (var vraag in VraagEnAntwoord)
            {
                if (vraag.Key == naam)
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean IngevuldeAntwoord(string naam, int antwoord)
        {
            if (VraagEnAntwoordAlGebruikt())
            {
                foreach (var VenA in VraagEnAntwoord)
                {
                    if (VenA.Key == naam && VenA.Value == antwoord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Boolean VraagEnAntwoordAlGebruikt()
        {
            return VraagEnAntwoord != null;
        }

        private Boolean AntwoordAlGegeven(string naam)
        {
            if (VraagEnAntwoordAlGebruikt())
            {

                foreach (var VenA in VraagEnAntwoord)
                {
                    if (VenA.Key == naam)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Boolean DataIsOpgehaald()
        {
            return (HelpMijKiezenVragenEnAntwoorden != null);
        }

        private void Sluiten()
        {
            _navigationManager.NavigateTo("stap2");
        }

    }
}
