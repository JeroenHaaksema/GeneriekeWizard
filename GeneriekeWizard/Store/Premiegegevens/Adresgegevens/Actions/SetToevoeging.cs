using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions
{
    public class SetToevoeging
{
        public string Toevoeging { get; set; }
        public SetToevoeging(string toevoeging)
        {
            Toevoeging = toevoeging;
        }
}
}
