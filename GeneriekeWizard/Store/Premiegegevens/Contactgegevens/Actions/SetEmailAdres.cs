using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Contactgegevens.Actions
{
    public class SetEmailAdres
{
        public string EmailAdres { get; set; }

        public SetEmailAdres(string emailAdres)
        {
            EmailAdres = emailAdres;
        }
    }
}
