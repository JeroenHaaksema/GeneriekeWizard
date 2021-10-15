using Bunit;
using Fluxor;
using GeneriekeWizard.Domain_Objects;
using GeneriekeWizard.Pages.Stap_3;
using GeneriekeWizard.Services;
using GeneriekeWizard.Store.Gezinssamenstelling;
using GeneriekeWizard.Store.Gezinssamenstelling.Actions.Persoonsgegevens;
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
    public class PersoonsgegevensDetailsTest
    {

        private readonly Mock<IState<GezinssamenstellingState>> _mockGezinssamenstellingState;
        private List<Persoon> personen;
        
        private Mock<PersoonModel> mockPersoonModel;

        public PersoonsgegevensDetailsTest()
        {
            _mockGezinssamenstellingState = new Mock<IState<GezinssamenstellingState>>();

            personen = new List<Persoon>()
            {
                VulTestPersoon(),
            };
        
            
            

            mockPersoonModel = new Mock<PersoonModel>();
        }

        private Persoon VulTestPersoon()
        {
            Persoon persoon = new Persoon(1, VerzekerdeType.Hoofdverzekerde);
            persoon.voorletters = "J";
            persoon.tussenvoegsel = null;
            persoon.achternaam = "Haaksema";
            persoon.geslacht = GeslachtEnum.Geslacht.Man;
            persoon.bsn = "12345678";
            return persoon;
        }

        [Fact]
        public void InitieleStateIsGemaakt()
        {
            //Arrange
            using var ctx = new TestContext();


            var _dispatcher = new Mock<IDispatcher>();
            var _actionSubscriber = new Mock<IActionSubscriber>();
            var gezinssamenstellingState = new GezinssamenstellingState(personen);

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);

            //Act 
            var cut = ctx.RenderComponent<PersoonsgegevensDetails>(parameters => parameters
            .Add(p => p.persoonId, 1));

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
            var gezinssamenstellingState = new GezinssamenstellingState(personen);

            ctx.Services.AddSingleton(_mockGezinssamenstellingState.Object);
            ctx.Services.AddSingleton(_dispatcher.Object);
            ctx.Services.AddSingleton(_actionSubscriber.Object);

            _mockGezinssamenstellingState.Setup(s => s.Value).Returns(gezinssamenstellingState);
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetVoorletters>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetTussenvoegsel>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetAchternaam>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetBSN>()));
            _dispatcher.Setup(x => x.Dispatch(It.IsAny<SetGeslacht>()));

            //Act 
            var cut = ctx.RenderComponent<PersoonsgegevensDetails>(parameters => parameters
            .Add(p => p.persoonId, 1));
            cut.Instance.HandleValidSubmit();
            //Assert
            Assert.NotNull(cut.Instance);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetVoorletters>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetTussenvoegsel>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetAchternaam>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetBSN>()), Times.Once);
            _dispatcher.Verify(x => x.Dispatch(It.IsAny<SetGeslacht>()), Times.Once);
        }
    }
}
