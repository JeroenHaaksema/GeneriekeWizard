using Bunit;
using Fluxor;
using GeneriekeWizard.Pages.Stap_3;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens;
using GeneriekeWizard.Store.Premiegegevens.Adresgegevens.Actions;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens;
using GeneriekeWizard.Store.Premiegegevens.Betaalgegevens.Actions;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens;
using GeneriekeWizard.Store.Premiegegevens.Contactgegevens.Actions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeneriekeWizard.UnitTest.Pages.Stap3_Test
{
    public class PremiegegevensTest
    {

        private readonly Mock<IState<AdresGegevensState>> _mockAdresGegevensState;
        private readonly Mock<IState<BetaalgegevensState>> _mockBetaalGegevensState;
        private readonly Mock<IState<ContactgegevensState>> _mockContactGegevensState;

        public PremiegegevensTest()
        {
            _mockAdresGegevensState = new Mock<IState<AdresGegevensState>>();
            _mockBetaalGegevensState = new Mock<IState<BetaalgegevensState>>();
            _mockContactGegevensState = new Mock<IState<ContactgegevensState>>();
        }

        [Fact]
        public void InitieleStateIsGemaakt()
        {
            //Arrange
            using var ctx = new TestContext();


            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();

            ctx.Services.AddSingleton(_mockAdresGegevensState.Object);
            ctx.Services.AddSingleton(_mockBetaalGegevensState.Object);
            ctx.Services.AddSingleton(_mockContactGegevensState.Object);

            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);


            //Act 
            var cut = ctx.RenderComponent<Premiegegevens>();

            //Assert
            Assert.NotNull(cut.Instance);
        }

        [Fact]
        public void SubmitIsUitgevoerd()
        {
            //Arrange
            using var ctx = new TestContext();


            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();

            ctx.Services.AddSingleton(_mockAdresGegevensState.Object);
            ctx.Services.AddSingleton(_mockBetaalGegevensState.Object);
            ctx.Services.AddSingleton(_mockContactGegevensState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetHuisnummer>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetLand>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetPostcode>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetBetaaltermijn>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetRekeningnummer>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetEmailAdres>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetTelefoonNummer>()));
            //Act 
            var cut = ctx.RenderComponent<PersoonsgegevensDetails>(parameters => parameters
            .Add(p => p.persoonId, 1));
            cut.Instance.HandleValidSubmit();

            //Assert
            Assert.NotNull(cut.Instance);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetHuisnummer>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetLand>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetPostcode>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetBetaaltermijn>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetRekeningnummer>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetEmailAdres>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetTelefoonNummer>()), Times.Once);
        }
    }
}
