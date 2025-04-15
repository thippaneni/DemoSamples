using Microsoft.AspNetCore.Mvc;
using SecureApiMvcClient.Models;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace SecureApiMvcClient.Controllers
{
    public class HomeController(IHttpClientFactory httpClientFactory, IConfiguration config) : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
        private readonly IConfiguration _config = config;

        public async Task<IActionResult> Index()
        {
            var response = await GetApiResponseAsync("/api/home/public");

            if (!response.IsSuccessStatusCode)
            {
                return RedirectToAction("Login", "Account",
                    new { message = "Access denied or token expired, to access public resources" });
            }

            ViewBag.Message = await response.Content.ReadAsStringAsync();
            return View();
        }
        public async Task<IActionResult> Admin()
        {
            var response = await GetApiResponseAsync("/api/home/admin");

            if (!response.IsSuccessStatusCode)
            {
                TempData["Message"] = "Access denied or token expired, to access Admin resources";
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = await response.Content.ReadAsStringAsync();
            return View();
        }

        public async Task<IActionResult> Dev()
        {
            var response = await GetApiResponseAsync("/api/home/dev");

            if (!response.IsSuccessStatusCode)
            {
                var loginMessage = "Access denied or token expired, to access Dev resources";
                HttpContext.Session.SetString("Message", loginMessage);
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = await response.Content.ReadAsStringAsync();
            return View();
        }

        public async Task<IActionResult> Qa()
        {
            var response = await GetApiResponseAsync("/api/home/qa");

            if (!response.IsSuccessStatusCode)
            {
                return RedirectToAction("Login", "Account",
                    new { message = "Access denied or token expired, to access QA resources" });
            }

            ViewBag.Message = await response.Content.ReadAsStringAsync();
            return View();
        }
        private async Task<HttpResponseMessage> GetApiResponseAsync(string endpoint)
        {
            var token = HttpContext.Session.GetString("AccessToken");
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync(_config["SecureApi:BaseUrl"] + endpoint);
            return response;
        }
    }
}
