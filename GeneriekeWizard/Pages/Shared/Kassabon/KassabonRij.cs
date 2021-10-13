using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Shared.Kassabon
{
    public partial class KassabonRij
    {

        [Inject]
        public IDispatcher Dispatcher { get; set; }
        [Parameter]
        public Persoon persoon { get; set; }

        [Parameter]
        public Basisverzekering? basisverzekering { get; set; }
        [Parameter]
        public Aanvullendeverzekering? aanvullendeverzekering { get; set; }
        [Parameter]
        public Tandverzekering tandverzekering { get; set; }

        public KassabonRij()
        {

        }

    }
}
