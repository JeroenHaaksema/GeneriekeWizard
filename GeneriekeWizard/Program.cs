using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using GeneriekeWizard.Pages.Shared.Navigatie;
using GeneriekeWizard.Services;
using System.Net.Mime;

namespace GeneriekeWizard
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var currentAssembly = typeof(Program).Assembly;
            builder.Services.AddFluxor(options =>
            {
                options.ScanAssemblies(currentAssembly);
                options.UseReduxDevTools();
            }
                );


            builder.Services.AddHttpClient<WizardAPIService>(client =>
            {
                client.DefaultRequestHeaders.Add("Content-Control", $"{MediaTypeNames.Application.Json}; charset=utf-8");
                client.BaseAddress = new Uri("http://localhost:4201");
            });


            await builder.Build().RunAsync();
        }
    }
}
