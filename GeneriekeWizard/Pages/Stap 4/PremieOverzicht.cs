using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_4
{
    public partial class PremieOverzicht
    {
        [Parameter]
        public IState<VerzekeringState> verzekeringState { get; set; }
        [Parameter]
        public IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        protected List<PremieOverzichtDTO> premieOverzichtDTOList { get; set; }
        protected Boolean gegevensGeladen { get; set; } = false;

        private string geen { get; } = "Geen keuze gemaakt";
        protected override void OnInitialized()
        {
            premieOverzichtDTOList = new List<PremieOverzichtDTO>();
            foreach(PersoonVerzekering persoonVerzekering in verzekeringState.Value.persoonVerzekeringen)
            {
                PremieOverzichtDTO premieOverzichtDTO = new PremieOverzichtDTO();
                premieOverzichtDTO.naam = gezinssamenstellingState.Value.personen.Find(x => x.id == persoonVerzekering.persoonId).GetNaam();
                premieOverzichtDTO.persoonVerzekering = persoonVerzekering;
                premieOverzichtDTOList.Add(premieOverzichtDTO);
            }

            gegevensGeladen = true;
            base.OnInitialized();
        }
    }
}
