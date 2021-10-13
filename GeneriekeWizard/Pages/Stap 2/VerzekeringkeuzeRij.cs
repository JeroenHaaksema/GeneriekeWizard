using GeneriekeWizard.Domain_Objects;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_2
{
    public partial class VerzekeringkeuzeRij
    {
        [Parameter]
        public VerzekeringTekst verzekeringTekst { get; set; }
        [Parameter]
        public PakketType? pakketType { get; set; }
        [Parameter]
        public Verzekering? verzekering { get; set; }


    }
}
