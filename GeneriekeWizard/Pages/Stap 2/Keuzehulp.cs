using GeneriekeWizard.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneriekeWizard.Domain_Objects;

namespace GeneriekeWizard.Pages.Stap_2
{
    public partial class Keuzehulp : ComponentBase
    {
        [Inject]
        WizardAPIService _wizardAPIService { get; set; }

        public List<KeuzehulptTekstblok> keuzehulpBlokken;
        public Keuzehulp(WizardAPIService wizardAPIService)
        {
            _wizardAPIService = wizardAPIService;
        }

        public Keuzehulp()
        {

        }
        protected override async Task OnInitializedAsync()
        {
            keuzehulpBlokken = await _wizardAPIService.GetAsync<List<KeuzehulptTekstblok>>("api/teksten/keuzehulp");
        }

        protected Boolean IsGeladen()
        {
            return keuzehulpBlokken != null;
        }

    }
}
