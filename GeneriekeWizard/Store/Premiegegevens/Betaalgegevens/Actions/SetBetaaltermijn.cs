using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.BetaaltermijnEnum;

namespace GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Actions
{
    public class SetBetaaltermijn
{
        public Betaaltermijn Betaaltermijn { get; set; }

        public SetBetaaltermijn (Betaaltermijn betaaltermijn)
        {
            Betaaltermijn = betaaltermijn;
        }
}
}
