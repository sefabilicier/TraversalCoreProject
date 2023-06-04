using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieController> apiMovies = new List<ApiMovieController>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                        {
                        { "X-RapidAPI-Key", "1e8ac42513msha3a848a04fc56bfp1797b8jsn1deaba150d1e" }, //profile key benim
                        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" }, //sağlayıcı key
                        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovies = JsonConvert.DeserializeObject<List<ApiMovieController>>(body);  
                return View(apiMovies);
            }

            
        }
    }
}
