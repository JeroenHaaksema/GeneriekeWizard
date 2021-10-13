using Fluxor;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using GeneriekeWizard.Store.Verzekering.Actions;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_2.VerzekeringsComponenten
{
    public partial class EigenRisicoComponent
    {
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        private List<int> eigenRisicoTredes { get; }


        public EigenRisicoComponent()
        {
            eigenRisicoTredes = new List<int>()
            {
                385, 485,565,655,785
            };
        }

        private void SelectEigenRisicoVoorPersoon(int persoonId, int eigenRisico)
        {
            var action = new SetEigenRisico(persoonId, eigenRisico);
            Dispatcher.Dispatch(action);
        }

        private Boolean Geselecteerd(int persoonId, int eigenRisico)
        {
            if((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId).Count() < 1)){
                return false;
            }

            if (verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.eigenRisico != eigenRisico).Count() > 0)
            {
                return false; 
            } else
            {
                return true;
            }
        }
    }
}
