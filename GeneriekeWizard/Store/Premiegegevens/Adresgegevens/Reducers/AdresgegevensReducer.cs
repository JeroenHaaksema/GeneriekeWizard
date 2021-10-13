using Fluxor;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Reducers
{
    public class AdresgegevensReducer
{

        [ReducerMethod]
        public static AdresGegevensState SetHuisnummer(AdresGegevensState state, SetHuisnummer action)
        {
            return new AdresGegevensState(
                land: state.Land,
                postcode: state.Postcode,
                huisnummer: action.Huisnummer,
                toevoeging: state.Toevoeging
                );
        }

        [ReducerMethod]
        public static AdresGegevensState SetLand(AdresGegevensState state, SetLand action)
        {
            return new AdresGegevensState(
                land: action.Land,
                postcode: state.Postcode,
                huisnummer: state.Huisnummer,
                toevoeging: state.Toevoeging
                );
        }

        [ReducerMethod]
        public static AdresGegevensState SetPostcode(AdresGegevensState state, SetPostcode action)
        {
            return new AdresGegevensState(
                land: state.Land,
                postcode: action.Postcode,
                huisnummer: state.Huisnummer,
                toevoeging: state.Toevoeging
                );
        }

        [ReducerMethod]
        public static AdresGegevensState SetToevoeging(AdresGegevensState state, SetToevoeging action)
        {
            return new AdresGegevensState(
                land: state.Land,
                postcode: state.Postcode,
                huisnummer: state.Huisnummer,
                toevoeging: action.Toevoeging
                );
        }

    }
}
