using Fluxor;
using GeneriekeWizard.Store.Gezinssamenstelling;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_3
{
    public partial class Persoonsgegevens
    {
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
    }
}
