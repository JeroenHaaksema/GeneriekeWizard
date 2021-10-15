using Fluxor;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Gezinssamenstelling.Gezinssamenstelling.Actions;
using GeneriekeWizard.Store.Verzekering.Actions.Delete;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_1
{
    public partial class Gezinssamenstelling
    {
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }


        public void VoegVolwasseneToe()
        {
            var action = new VoegVolwasseneToe();
            Dispatcher.Dispatch(action);
        }
        public void VerwijderVolwassene()
        {
            var action = new VerwijderVolwassene();
            var action2 = new DeletePersoon(gezinssamenstellingState.Value.personen.ToList().FindAll(x => !x.IsKind()).Max(x => x.id));
            Dispatcher.Dispatch(action);
            Dispatcher.Dispatch(action2);

        }
        public void VoegKindToe()
        {
            var action = new VoegKindToe();
            Dispatcher.Dispatch(action);
        }

        public void VerwijderKind()
        {
            var action = new VerwijderKind();
            var action2 = new DeletePersoon(gezinssamenstellingState.Value.personen.ToList().FindAll(x => x.IsKind()).Max(x => x.id));
            Dispatcher.Dispatch(action);
            Dispatcher.Dispatch(action2);

        }
    }
}
