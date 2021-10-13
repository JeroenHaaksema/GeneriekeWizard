using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_2
{
    public partial class VerzekeringKeuze : ComponentBase
    {
        [Inject]
        protected WizardAPIService _wizardAPIService { get; set; }

        public VerzekeringTekstenDTO verzekeringTekstenDTO { get; set; }
        public VerzekeringDTO verzekeringDTO { get; set; }

        public VerzekeringKeuze(WizardAPIService wizardAPIService)
        {
            _wizardAPIService = wizardAPIService;
        }

        public VerzekeringKeuze()
        {

        }

        protected override async Task OnInitializedAsync()
        {
            verzekeringTekstenDTO = await _wizardAPIService.GetAsync<VerzekeringTekstenDTO>("api/teksten/verzekeringen");
            verzekeringDTO = new VerzekeringDTO();
            verzekeringDTO.aanvullendeVerzekeringen = await _wizardAPIService.GetAsync<List<Aanvullendeverzekering>>("api/verzekering/aanvullend");
            verzekeringDTO.basisVerzekeringen = await _wizardAPIService.GetAsync<List<Basisverzekering>>("api/verzekering/basis");
            verzekeringDTO.tandVerzekeringen = await _wizardAPIService.GetAsync<List<Tandverzekering>>("api/verzekering/tand");
        }

        protected Boolean IsGeladen()
        {
            return verzekeringTekstenDTO != null && verzekeringDTO != null;
        }

        protected Verzekering VindVerzekering(PakketType pakketType, int id)
        {
            switch (pakketType)
            {
                case PakketType.Basis:
                    {
                        return verzekeringDTO.basisVerzekeringen.Find(x => x.id == id);
                    }
                case PakketType.Aanvullend:
                    {
                        return verzekeringDTO.aanvullendeVerzekeringen.Find(x => x.id == id);
                    }
                case PakketType.Tand:
                    {  
                    return verzekeringDTO.tandVerzekeringen.Find(x => x.id == id);
                    }
                default:
                    {
                        return new Verzekering();
                    }
            }
        }
    }
}
