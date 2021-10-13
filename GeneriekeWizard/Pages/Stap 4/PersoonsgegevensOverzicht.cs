using Fluxor;
using GeneriekeWizard.Store.Gezinssamenstelling;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_4
{
    public partial class PersoonsgegevensOverzicht
    {
        [Parameter]
        public IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }


    }
}
