using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using System.Net.Http.Headers;

namespace SecureApiMvcClient.Controllers
{
    public class AccountController(IHttpClientFactory httpClientFactory, IConfiguration config) : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
        private readonly IConfiguration _config = config;

        [HttpGet]
        public IActionResult Login(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = TempData["Message"]?.ToString() ?? string.Empty;
                TempData["Message"] = string.Empty;
            }
            if (string.IsNullOrEmpty(message))
            {
                message = HttpContext.Session.GetString("Message") ?? string.Empty;
                HttpContext.Session.Remove("Message");
            }
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {            
            var loginDto = new { username, password };

            var client = _httpClientFactory.CreateClient();
            var response = await client.PostAsync(
                _config["SecureApi:BaseUrl"] + "/api/auth/login",
                new StringContent(JsonSerializer.Serialize(loginDto), Encoding.UTF8, "application/json")
            );

            if (!response.IsSuccessStatusCode) return View();

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);
            var token = doc.RootElement.GetProperty("token").GetString();

            HttpContext.Session.SetString("AccessToken", token ?? string.Empty);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            var token = HttpContext.Session.GetString("AccessToken");
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                await client.PostAsync(_config["SecureApi:BaseUrl"] + "/api/auth/logout", null);
            }

            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
