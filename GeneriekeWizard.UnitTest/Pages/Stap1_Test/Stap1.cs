using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void VoegVolwasseneToeWerkt()
        {
            // Arrange
            using var ctx = new TestContext();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);
            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var _reducer = new Mock<GezinssamenstellingReducer>();
            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);
            ctx.Services.AddSingleton(_reducer.Object);


            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);
            _reducer.Setup(x = > x.AddVolwasseneAction()).Returns()
            _
            // Act
            var cut = ctx.RenderComponent<Gezinssamenstelling>();
            cut.Instance.VoegVolwasseneToe();

            //Assert
            Assert.True(gezinssamenstellingState.personen.Count.Equals(2));
        }
    }

    }