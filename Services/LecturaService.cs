using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgroTech.Models;

namespace AgroTech.Services
{
    public class LecturaService
    {
        private readonly HttpClient _http;

        public LecturaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<LecturaSensor>> GetLecturasAsync()
        {
            return await _http.GetFromJsonAsync<List<LecturaSensor>>("api/lecturas") ?? new List<LecturaSensor>();
        }
    }
}