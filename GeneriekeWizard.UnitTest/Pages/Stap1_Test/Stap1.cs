using System.Collections.Generic;
using Xunit;
using Bunit;
using GeneriekeWizard.Pages.Stap_1;
using Fluxor;
using Moq;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Domain_Objects;
using Microsoft.Extensions.DependencyInjection;
using GeneriekeWizard.Store.Gezinssamenstelling.Gezinssamenstelling.Actions;
using GeneriekeWizard.Store.Gezinssamenstelling.Reducers;

namespace GeneriekeWizard.UnitTest.Pages.Stap1_Test
{
    public class Stap1
    {


        private readonly Mock<IState<GezinssamenstellingState>> _mockGezinssamenstellingState;
        private List<Persoon> personen;

        public Stap1() {
            _mockGezinssamenstellingState = new Mock<IState<GezinssamenstellingState>>();
            personen = new List<Persoon>()
            {
                new Persoon(1, VerzekerdeType.Hoofdverzekerde),
            };
        }

        [Fact]
        public void InitieleStateIsGemaakt()
        {
            // Arrange
            using var ctx = new TestContext();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);
            
            // Act
            var cut = ctx.RenderComponent<Gezinssamenstelling>();

            // Assert
            Assert.NotNull(cut.Instance);
        }


        [Fact]
        public void VoegVolwasseneToeWordtUitgevoerd()
        {
            //Arrange
            using var ctx = new TestContext();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            Mock<IDispatcher> _dispatcher = new Mock<IDispatcher>();
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<VoegVolwasseneToe>()));
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var _reducer = new Mock<GezinssamenstellingReducer>();

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);
            ctx.Services.AddSingleton(_reducer.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);

            

            var cut = ctx.RenderComponent<Gezinssamenstelling>();
            cut.Instance.VoegVolwasseneToe();

            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<VoegVolwasseneToe>()), Times.Once);
        }

        [Fact]
        public void VerwijderVolwasseneWordtUitgevoerd()
        {
            //Arrange
            using var ctx = new TestContext();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            Mock<IDispatcher> _dispatcher = new Mock<IDispatcher>();
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<VerwijderVolwassene>()));
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var _reducer = new Mock<GezinssamenstellingReducer>();

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);
            ctx.Services.AddSingleton(_reducer.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);



            var cut = ctx.RenderComponent<Gezinssamenstelling>();
            cut.Instance.VerwijderVolwassene();

            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<VerwijderVolwassene>()), Times.Once);
        }

        [Fact]
        public void VoegKindToeWordtUitgevoerd()
        {
            //Arrange
            using var ctx = new TestContext();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            Mock<IDispatcher> _dispatcher = new Mock<IDispatcher>();
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<VoegKindToe>()));
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var _reducer = new Mock<GezinssamenstellingReducer>();

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);
            ctx.Services.AddSingleton(_reducer.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);



            var cut = ctx.RenderComponent<Gezinssamenstelling>();
            cut.Instance.VoegKindToe();

            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<VoegKindToe>()), Times.Once);
        }

        [Fact]
        public void VerwijderKindWordtUitgevoerd()
        {
            //Arrange
            using var ctx = new TestContext();
            List<Persoon> gezinsstateMetKinderen = new List<Persoon>()
            {
            new Persoon(1, VerzekerdeType.Hoofdverzekerde),
            new Persoon(2, VerzekerdeType.Kind),
            new Persoon(3, VerzekerdeType.Kind),
            };
        
            var gezinssamenstellingState = new GezinssamenstellingState(gezinsstateMetKinderen);
            Mock<IDispatcher> _dispatcher = new Mock<IDispatcher>();
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<VerwijderKind>()));
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var _reducer = new Mock<GezinssamenstellingReducer>();

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);
            ctx.Services.AddSingleton(_reducer.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);


            //Act
            var cut = ctx.RenderComponent<Gezinssamenstelling>();
            cut.Instance.VerwijderKind();

            //Assert
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<VerwijderKind>()), Times.Once);
        }
    }

    

    }