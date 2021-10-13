using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.BetaalTypeEnum;

namespace GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Actions
{
    public class SetBetaaltype
{
        public BetaalType BetaalType { get; set; }

        public SetBetaaltype(BetaalType betaalType)
        {
            BetaalType = betaalType;
        }
}
}
