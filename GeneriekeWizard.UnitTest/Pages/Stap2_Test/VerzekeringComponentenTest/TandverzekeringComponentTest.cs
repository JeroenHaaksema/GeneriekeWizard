using Bunit;
using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Pages.Stap_2.VerzekeringsComponenten;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Verzekering;
using GeneriekeWizard.Store.Verzekering.Actions.Delete;
using GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene;
using GeneriekeWizard.Store.Verzekering.Actions.UpdateVerzekeringKind;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeneriekeWizard.UnitTest.Pages.Stap2_Test.VerzekeringComponentenTest
{
    public class TandverzekeringComponentTest
    {
        private readonly List<TandverzekeringTekst> tandVerzekeringsTeksten;
        private readonly List<Tandverzekering> tandVerzekeringen;
        private readonly Mock<IState<GezinssamenstellingState>> _mockGezinssamenstellingState;
        private readonly Mock<IState<VerzekeringState>> _mockVerzekeringState;
        private List<Persoon> personen;
        List<PersoonVerzekering> persoonVerzekeringen;

        public TandverzekeringComponentTest()
        {
            _mockGezinssamenstellingState = new Mock<IState<GezinssamenstellingState>>();
            _mockVerzekeringState = new Mock<IState<VerzekeringState>>();

            tandVerzekeringsTeksten = new List<TandverzekeringTekst>()
            {
                new TandverzekeringTekst { id=1, naam ="Basis Keuze", tekst="Meer blabla", prijs=11 },
                new TandverzekeringTekst { id=2, naam ="Ruime Keuze", tekst="Meer blabla", prijs=13 },
                new TandverzekeringTekst { id=3, naam ="Ruimste Keuze", tekst="Meer blabla", prijs=17 },
            };
            tandVerzekeringen = new List<Tandverzekering>()
             {

                new Tandverzekering {id=1, naam="Basis Keuze", prijs=11},
                new Tandverzekering {id=2, naam="Ruime Keuze", prijs=13},
                new Tandverzekering {id=3, naam="Ruimste Keuze", prijs=17},
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
            var cut = ctx.RenderComponent<TandverzekeringComponent>(parameters => parameters
            .Add(p => p.tandverzekeringen, tandVerzekeringen)
            .Add(p => p.tandverzekeringsTeksten, tandVerzekeringsTeksten));
            //Assert
            Assert.NotNull(cut.Instance);
        }

        [Fact]
        public void SelectTandVerzekeringTest()
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

            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetTandVerzekering>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<UpdateTandVerzekeringKind>()));

            var cut = ctx.RenderComponent<TandverzekeringComponent>(parameters => parameters
            .Add(p => p.tandverzekeringen, tandVerzekeringen)
            .Add(p => p.tandverzekeringsTeksten, tandVerzekeringsTeksten));

            //Act 
            cut.Instance.SelectTandVerzekering(1, 1);
            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetTandVerzekering>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<UpdateTandVerzekeringKind>()), Times.Once);
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

            _dispatcher.Setup(x => x.Dispatch(It.IsAny<DeleteTandVerzekering>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<UpdateTandVerzekeringKind>()));

            var cut = ctx.RenderComponent<TandverzekeringComponent>(parameters => parameters
            .Add(p => p.tandverzekeringen, tandVerzekeringen)
            .Add(p => p.tandverzekeringsTeksten, tandVerzekeringsTeksten));

            //Act 
            cut.Instance.DeleteTandVerzekering(1);
            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<DeleteTandVerzekering>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<UpdateTandVerzekeringKind>()), Times.Once);
        }
    }
}
