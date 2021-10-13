using Fluxor;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Premiegegevens.Contactgegevens.Reducers
{
    public class ContactgegevensReducer
{

    [ReducerMethod]
    public static ContactgegevensState SetEmailAdres(ContactgegevensState state, SetEmailAdres action)
    {

            return new ContactgegevensState(
                emailAdres: action.EmailAdres,
                telefoonNummer: state.TelefoonNummer
                );
    }

    [ReducerMethod]
    public static ContactgegevensState SetTelefoonNummer(ContactgegevensState state, SetTelefoonNummer action)
    {

        return new ContactgegevensState(
            emailAdres: state.EmailAdres,
            telefoonNummer: action.TelefoonNummer
            );
    }

    }
}
