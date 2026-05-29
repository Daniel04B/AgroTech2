using System.Net.Http.Json;
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

        // =========================================
        // REGISTRO
        // =========================================
        public async Task<string?> RegistrarAsync(
            Agricultor agricultor)
        {
            try
            {
                var response =
                    await _http.PostAsJsonAsync(
                        "api/agricultores/registro",
                        agricultor);

                if (response.IsSuccessStatusCode)
                    return null;

                return await response.Content
                    .ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // =========================================
        // LOGIN
        // =========================================
        public async Task<Agricultor?> LoginAsync(
            string usuario,
            string contraseña)
        {
            try
            {
                var loginRequest = new
                {
                    Usuario = usuario,
                    Contrasena = contraseña
                };

                var response =
                    await _http.PostAsJsonAsync(
                        "api/agricultores/login",
                        loginRequest);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content
                        .ReadFromJsonAsync<Agricultor>();
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}