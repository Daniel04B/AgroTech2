using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AgroTech.Models;

namespace AgroTech.Services
{
    public class AgricultorService
    {
        private readonly HttpClient _http;

        public AgricultorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string?> RegistrarAsync(Agricultor agricultor)
        {
            var response = await _http.PostAsJsonAsync("api/agricultores/registro", agricultor);

            if (response.IsSuccessStatusCode)
                return null; // Éxito completo

            // Si da error 400, extrae el texto exacto enviado por la API
            var mensajeError = await response.Content.ReadAsStringAsync();
            return !string.IsNullOrEmpty(mensajeError) ? mensajeError : "Error desconocido en el registro.";
        }

        public async Task<Agricultor?> LoginAsync(string usuario, string contraseña)
        {
            var loginRequest = new { Usuario = usuario, Contrasena = contraseña };
            var response = await _http.PostAsJsonAsync("api/agricultores/login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Agricultor>();
            }

            return null; // Credenciales inválidas (401)
        }
    }
}