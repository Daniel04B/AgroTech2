using System.Net.Http.Json;
using AgroTech.Models;

namespace AgroTech.Services
{
    public class SensorService
    {
        private readonly HttpClient _http;

        public SensorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Sensor>> GetSensoresPorUsuarioAsync(int agricultorId)
        {
            return await _http.GetFromJsonAsync<List<Sensor>>
            (
                $"api/sensores/usuario/{agricultorId}"
            ) ?? new List<Sensor>();
        }

        public async Task<bool> CreateSensorAsync(Sensor sensor)
        {
            var response = await _http.PostAsJsonAsync(
                "api/sensores",
                sensor);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateSensorAsync(Sensor sensor)
        {
            var response = await _http.PutAsJsonAsync(
                $"api/sensores/{sensor.Id}",
                sensor);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSensorAsync(int id)
        {
            var response = await _http.DeleteAsync(
                $"api/sensores/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}