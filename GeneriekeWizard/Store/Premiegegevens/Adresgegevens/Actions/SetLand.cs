using GeneriekeWizard.Domain_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions
{
    public class SetLand
{
        public Land Land { get; set; }

        public SetLand(Land land)
        {
            Land = land;
        }
}
}
