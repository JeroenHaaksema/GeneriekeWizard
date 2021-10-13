using Fluxor;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_4
{
    public partial class PremieGegevensOverzicht
    {
        [Parameter]
        public IState<AdresGegevensState> adresgegevensState { get; set; }
        [Parameter]
        public IState<BetaalgegevensState> betaalgegevensState { get; set; }
        [Parameter]
        public IState<ContactgegevensState> contactgegevensState { get; set; }
    }
}
