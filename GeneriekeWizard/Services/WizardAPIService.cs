using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace GeneriekeWizard.Services
{
    public class WizardAPIService
    {
        private readonly HttpClient _http;

        public WizardAPIService(HttpClient http)
        {
            this._http = http;
        }

        public Task<TResponse> GetAsync<TResponse>(string path)
        {
            return _http.GetFromJsonAsync<TResponse>(path);
        }
        public Task<HttpResponseMessage> PostAsync<TBody>(string path, TBody body)
        {
            return _http.PostAsJsonAsync(path, body);
        }


    }
}
