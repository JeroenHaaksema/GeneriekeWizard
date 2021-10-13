using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Gezinssamenstelling.Gezinssamenstelling.Actions;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Shared.Kassabon
{
    public partial class Kassabon
    {
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        public void VerwijderKind(int persoonsId)
        {
            var action = new VerwijderKind(persoonsId);
            Dispatcher.Dispatch(action);
        }

        public void VerwijderVolwassene(int persoonId)
        {
            var action = new VerwijderVolwassene(persoonId);
            Dispatcher.Dispatch(action);
        }

        public Boolean BasisverzekeringGekozen(int persoonId)
        {
            if ((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.basisverzekering != null).Count() > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Basisverzekering VindBasisVerzekering(int persoonId)
        {
            if (BasisverzekeringGekozen(persoonId))
            {
                return verzekeringState.Value.persoonVerzekeringen.Find(x => x.persoonId == persoonId).basisverzekering;
            }
            else
            {
                return null;
            }
        }

        public Boolean AanvullendeverzekeringGekozen(int persoonId)
        {
            if ((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.aanvullendeverzekering != null).Count() > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Aanvullendeverzekering VindAanvullendeVerzekering(int persoonId)
        {
            if (AanvullendeverzekeringGekozen(persoonId))
            {
                return verzekeringState.Value.persoonVerzekeringen.Find(x => x.persoonId == persoonId).aanvullendeverzekering;
            }
            else
            {
                return null;
            }
        }
        public Boolean TandverzekeringGekozen(int persoonId)
        {
            if ((verzekeringState.Value.persoonVerzekeringen.FindAll(x => x.persoonId == persoonId && x.tandverzekering != null).Count() > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Tandverzekering VindTandVerzekering(int persoonId)
        {
            if (TandverzekeringGekozen(persoonId))
            {
                return verzekeringState.Value.persoonVerzekeringen.Find(x => x.persoonId == persoonId).tandverzekering;
            }
            else
            {
                return null;
            }
        }

        public int BerekenTotaalPrijs()
        {
            List<Persoon> personen = gezinssamenstellingState.Value.personen;
            int totaal = 0;
            foreach (var persoon in personen)
            {
                if (BasisverzekeringGekozen(persoon.id))
                {
                    totaal += VindBasisVerzekering(persoon.id).prijs;
                }
                if (AanvullendeverzekeringGekozen(persoon.id))
                {
                    totaal += VindAanvullendeVerzekering(persoon.id).prijs;
                }
                if (TandverzekeringGekozen(persoon.id))
                {
                    totaal += VindTandVerzekering(persoon.id).prijs;
                }
            }
            return totaal;
        }
    }
}
