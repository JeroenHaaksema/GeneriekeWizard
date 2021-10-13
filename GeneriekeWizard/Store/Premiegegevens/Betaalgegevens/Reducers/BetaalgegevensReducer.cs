using Fluxor;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Reducers
{
    public class BetaalgegevensReducer
{

    [ReducerMethod]
    public static BetaalgegevensState SetBetaaltermijn(BetaalgegevensState state, SetBetaaltermijn action)
    {

        return new BetaalgegevensState(
            rekeningnummer: state.RekeningNummer,
            betaaltermijn: action.Betaaltermijn,
            betaalType: state.BetaalType
            );
    }

    [ReducerMethod]
    public static BetaalgegevensState SetBetaaltype(BetaalgegevensState state, SetBetaaltype action)
    {

        return new BetaalgegevensState(
            rekeningnummer: state.RekeningNummer,
            betaaltermijn: state.BetaalTermijn,
            betaalType: action.BetaalType
            );
    }
        [ReducerMethod]
        public static BetaalgegevensState SetRekeningnummer(BetaalgegevensState state, SetRekeningnummer action)
        {

            return new BetaalgegevensState(
                rekeningnummer: action.Rekeningnummer,
                betaaltermijn: state.BetaalTermijn,
                betaalType: state.BetaalType
                );
        }

    }
}
