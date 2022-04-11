using GoalSystemsFront.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GoalSystemsFront.Controllers
{
    public class IncidenciasController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public IncidenciasController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public async Task<ActionResult> ListadoIncidencias()
        {
            List<IncidenciasListado> incidencias = new List<IncidenciasListado>();
            try
            {
                var client = _httpClient.CreateClient("GoalSystems");
                var response = await client.GetAsync("https://localhost:5001/api/Incidencias/GetIncidenciasByEmpleado/1");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    
                    incidencias = JsonSerializer.Deserialize<List<IncidenciasListado>>(content,options);


                    return View(incidencias);
                }
                return View(incidencias);

            }
            catch
            {
                return View("Error");
            }
        }                
    }
}
