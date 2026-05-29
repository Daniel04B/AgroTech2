using System.Net.Http.Json;
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

        // =========================================
        // GET
        // =========================================
        public async Task<List<Zona>> GetZonasAsync()
        {
            return await _http.GetFromJsonAsync<List<Zona>>(
                "api/zonas")
                ?? new List<Zona>();
        }

        // =========================================
        // CREATE
        // =========================================
        public async Task<bool> CreateZonaAsync(Zona zona)
        {
            var response =
                await _http.PostAsJsonAsync(
                    "api/zonas",
                    zona);

            return response.IsSuccessStatusCode;
        }

        // =========================================
        // UPDATE
        // =========================================
        public async Task<bool> UpdateZonaAsync(Zona zona)
        {
            var response =
                await _http.PutAsJsonAsync(
                    $"api/zonas/{zona.Id}",
                    zona);

            return response.IsSuccessStatusCode;
        }

        // =========================================
        // DELETE
        // =========================================
        public async Task<bool> DeleteZonaAsync(int id)
        {
            var response =
                await _http.DeleteAsync(
                    $"api/zonas/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}