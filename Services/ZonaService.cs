using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgroTech.Models;

namespace AgroTech.Services
{
    public class ZonaService
    {
        private readonly HttpClient _http;

        public ZonaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Zona>> GetZonasAsync()
        {
            return await _http.GetFromJsonAsync<List<Zona>>("api/zonas") ?? new List<Zona>();
        }

        public async Task<bool> CreateZonaAsync(Zona zona)
        {
            var response = await _http.PostAsJsonAsync("api/zonas", zona);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteZonaAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/zonas/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}