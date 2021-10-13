using Fluxor;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_2
{
    public partial class Stap2
    {
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }

        protected Boolean VolgendeStapToegestaan()
        {
            return BasisverzekeringGekozen() && EigenRisicoGekozen();
        }
        private Boolean BasisverzekeringGekozen()
        {
            if (gezinssamenstellingState.Value.personen.FindAll(x => !x.IsKind()).Count() > verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.basisverzekering != null).Count())
            {
                return false;
            } else { 
                return true;
            }
        }

        private Boolean EigenRisicoGekozen()
        {
            if (gezinssamenstellingState.Value.personen.FindAll(x => !x.IsKind()).Count() > verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.eigenRisico != 0).Count())
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
