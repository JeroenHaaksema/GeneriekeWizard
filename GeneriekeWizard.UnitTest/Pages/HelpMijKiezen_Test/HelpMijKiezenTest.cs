using Bunit;
using GeneriekeWizard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeneriekeWizard.UnitTest.Pages.HelpMijKiezen_Test
{
    public class HelpMijKiezenTest
    {

        public HelpMijKiezenTest()
        {

        }

        [Fact]
        public void InitieleStateIsGemaakt()
        {
            //Arrange
            using var ctx = new TestContext();


            var _dispatcher = new Mock<WizardAPIService>();
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
    }
}
