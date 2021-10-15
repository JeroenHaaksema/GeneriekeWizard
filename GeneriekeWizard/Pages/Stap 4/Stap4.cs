using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Services;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Pages.Stap_4
{
    public partial class Stap4
    {
        [Inject]
        private IState<GezinssamenstellingState> gezinssamenstellingState { get; set; }
        [Inject]
        private IState<VerzekeringState> verzekeringState { get; set; }
        [Inject]
        private IState<AdresGegevensState> adresGegevensState { get; set; }
        [Inject]
        private IState<BetaalgegevensState> betaalGegevensState { get; set; }
        [Inject]
        private IState<ContactgegevensState> contactGegevensState { get; set; }
        [Inject]
        protected WizardAPIService _wizardAPIService { get; set; }


        private VerstuurVerzekeringDTO verstuurVerzekeringDTO { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private Boolean verzonden { get; set; } = false;

        public Stap4()
        {

        }

        public Stap4(WizardAPIService wizardAPIService)
        {
            _wizardAPIService = wizardAPIService;
        }

        protected Boolean Verzonden()
        {
            return verzonden;
        }

        private void VerstuurVerzekering()
        {
            try { 
            _wizardAPIService.PostAsync("/api/wizard", VerzamelGegevens());
            } catch(Exception e)
            {
                throw new Exception(""+e);
            }
            finally
            {
                verzonden = true;
            }

        }

     
        private VerstuurVerzekeringDTO VerzamelGegevens()
        {
            List<PersoonDTO> persoonsgegevens = VerzamelPersoonsGegevens();
            persoonsgegevens = VerzamelVerzekeringen(persoonsgegevens);
            return new VerstuurVerzekeringDTO(persoonsgegevens);
        }

        private List<PersoonDTO> VerzamelPersoonsGegevens()
        {
            List<PersoonDTO> persoonsgegevens = new List<PersoonDTO>();
            foreach(var persoon in gezinssamenstellingState.Value.personen)
            {
                
                var tussenvoegsel = persoon.tussenvoegsel != null ? persoon.tussenvoegsel : null;
                PersoonDTO persoonDTO = new PersoonDTO(persoon.id,persoon.verzekerdeType,persoon.voorletters,persoon.achternaam, persoon.geslacht, persoon.nationaliteit, persoon.bsn, tussenvoegsel);
                persoonsgegevens.Add(persoonDTO);
            }
            return persoonsgegevens;
        }

        private List<PersoonDTO> VerzamelVerzekeringen(List<PersoonDTO> persoonsgegevens)
        {
            foreach(PersoonDTO persoon in persoonsgegevens)
            {
                foreach(PersoonVerzekering persoonVerzekering in verzekeringState.Value.persoonVerzekeringen)
                {
                    if(persoon.id == persoonVerzekering.persoonId)
                    {
                        persoon.basisverzekering = persoonVerzekering.basisverzekering;
                        persoon.eigenRisico = persoonVerzekering.eigenRisico;
                        if(persoonVerzekering.aanvullendeverzekering != null)
                        {
                            persoon.aanvullendeverzekering = persoonVerzekering.aanvullendeverzekering;
                        }
                        if (persoonVerzekering.tandverzekering != null)
                        {
                            persoon.tandverzekering = persoonVerzekering.tandverzekering;
                        }

                    }
                }
            }
            return persoonsgegevens;
        }

        
    }
}
