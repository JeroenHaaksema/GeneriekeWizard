using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.BetaaltermijnEnum;
using static GeneriekeWizard.Domain_Objects.BetaalTypeEnum;


namespace GeneriekeWizard.Store.Premiegegevens.Betaalgegevens
{
    public class BetaalgegevensState
{
        public string RekeningNummer { get; set; }
        public Betaaltermijn BetaalTermijn { get; set; }
        public BetaalType BetaalType { get; set; }

        public BetaalgegevensState(string rekeningnummer, Betaaltermijn betaaltermijn, BetaalType betaalType)
        {
            this.RekeningNummer = rekeningnummer;
            this.BetaalTermijn = betaaltermijn;
            this.BetaalType = betaalType;
        }
    }
}
