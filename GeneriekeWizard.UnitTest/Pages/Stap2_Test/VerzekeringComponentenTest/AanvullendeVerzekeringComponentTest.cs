using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bunit;
using GeneriekeWizard.Pages.Stap_2.VerzekeringsComponenten;
using GeneriekeWizard.Domain_Objects;
using Fluxor;
using Moq;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using Microsoft.Extensions.DependencyInjection;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind;
using GeneriekeWizard.Store.Verzekering.Actions.Delete;

namespace GeneriekeWizard.UnitTest.Pages.Stap2_Test.VerzekeringComponentenTest
{
    public class AanvullendeVerzekeringComponentTest
    {
        private readonly List<AanvullendeverzekeringTekst> aanvullendeVerzekeringsTeksten;
        private readonly List<Aanvullendeverzekering> aanvullendeVerzekeringen;
        private readonly Mock<IState<GezinssamenstellingState>> _mockGezinssamenstellingState;
        private readonly Mock<IState<VerzekeringState>> _mockVerzekeringState;
        private List<Persoon> personen;
        List<PersoonVerzekering> persoonVerzekeringen;

        public AanvullendeVerzekeringComponentTest()
        {
            _mockGezinssamenstellingState = new Mock<IState<GezinssamenstellingState>>();
            _mockVerzekeringState = new Mock<IState<VerzekeringState>>();

            aanvullendeVerzekeringsTeksten = new List<AanvullendeverzekeringTekst>()
            {
                new AanvullendeverzekeringTekst { id=1, naam ="Basis Keuze", tekst="Meer blabla", prijs=11 },
                new AanvullendeverzekeringTekst { id=2, naam ="Ruime Keuze", tekst="Meer blabla", prijs=13 },
                new AanvullendeverzekeringTekst { id=3, naam ="Ruimste Keuze", tekst="Meer blabla", prijs=17 },
            };
             aanvullendeVerzekeringen = new List<Aanvullendeverzekering>() 
             {

                new Aanvullendeverzekering {id=1, naam="Basis Keuze", prijs=11},
                new Aanvullendeverzekering {id=2, naam="Ruime Keuze", prijs=13},
                new Aanvullendeverzekering {id=3, naam="Ruimste Keuze", prijs=17},
             };

            personen = new List<Persoon>()
            {
                new Persoon(1, VerzekerdeType.Hoofdverzekerde),
                new Persoon(2, VerzekerdeType.Kind),
                new Persoon(3, VerzekerdeType.Kind),
            };

            persoonVerzekeringen = new List<PersoonVerzekering>()
            {
                new PersoonVerzekering(1, null,null,null, 0),
                new PersoonVerzekering(2, null,null,null, 0),
                new PersoonVerzekering(3, null,null,null, 0),
            };

        }

        [Fact]
        public void InitieleStateIsGemaakt()
        {
            //Arrange
            using var ctx = new TestContext();

            
            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            var verzekeringState = new VerzekeringState(persoonVerzekeringen);

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_mockVerzekeringState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);
            _mockVerzekeringState.Setup(s => s.Value).Returns(verzekeringState);

            //Act 
            var cut = ctx.RenderComponent<AanvullendeVerzekeringComponent>(parameters => parameters
            .Add(p => p.aanvullendeverzekeringen, aanvullendeVerzekeringen)
            .Add(p => p.aanvullendeverzekeringsTeksten, aanvullendeVerzekeringsTeksten));
            //Assert
            Assert.NotNull(cut.Instance);
        }

        [Fact]
        public void SelectAanvullendeVerzekeringTest()
        {
            //Arrange
            using var ctx = new TestContext();


            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            var verzekeringState = new VerzekeringState(persoonVerzekeringen);

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_mockVerzekeringState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);
            _mockVerzekeringState.Setup(s => s.Value).Returns(verzekeringState);

            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetAanvullendeVerzekering>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<UpdateAanvullendeVerzekeringKind>()));

            var cut = ctx.RenderComponent<AanvullendeVerzekeringComponent>(parameters => parameters
            .Add(p => p.aanvullendeverzekeringen, aanvullendeVerzekeringen)
            .Add(p => p.aanvullendeverzekeringsTeksten, aanvullendeVerzekeringsTeksten));

            //Act 
            cut.Instance.SelectAanvullendeVerzekering(1,1);
            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetAanvullendeVerzekering>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<UpdateAanvullendeVerzekeringKind>()), Times.Once);
        }

        [Fact]
        public void VerwijderAanvullendeVerzekeringTest()
        {
            //Arrange
            using var ctx = new TestContext();


            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            var verzekeringState = new VerzekeringState(persoonVerzekeringen);

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_mockVerzekeringState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);
            _mockVerzekeringState.Setup(s => s.Value).Returns(verzekeringState);

            _dispatcher.Setup(x => x.Dispatch(It.IsAny<DeleteAanvullendeVerzekering>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<UpdateAanvullendeVerzekeringKind>()));

            var cut = ctx.RenderComponent<AanvullendeVerzekeringComponent>(parameters => parameters
            .Add(p => p.aanvullendeverzekeringen, aanvullendeVerzekeringen)
            .Add(p => p.aanvullendeverzekeringsTeksten, aanvullendeVerzekeringsTeksten));

            //Act 
            cut.Instance.DeleteAanvullendeVerzekering(1);
            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<DeleteAanvullendeVerzekering>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<UpdateAanvullendeVerzekeringKind>()), Times.Once);
        }
    }
}
