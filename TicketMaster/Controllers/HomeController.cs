using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TicketMaster.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace TicketMaster.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string _apiKey = "Ve0GnDy9niAOUWMpkMKwj49c7bdVdbMK";
        private readonly string _baseUrl = "https://app.ticketmaster.com/discovery/v2/";
       // private readonly string _attractionUrl = "https://app.ticketmaster.com/discovery/v2/attractions.json";
        private readonly string _eventUrl = "https://app.ticketmaster.com/discovery/v2/events.json"; //?attractionId=K8vZ917Gku7&countryCode=CA&apikey=Ve0GnDy9niAOUWMpkMKwj49c7bdVdbMK";
        //private readonly string _SpecificUrl = "https://app.ticketmaster.com/discovery/v2/attractions/"; K8vZ9175BhV.json?apikey=Ve0GnDy9niAOUWMpkMKwj49c7bdVdbMK",

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Attractions(string keyword)
        {
            // Construct the attractions URL with parameters
            string attractionUrl = $"{_baseUrl}attractions.json?keyword={keyword}&apikey={_apiKey}&size=20";

            // Make the API request
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(attractionUrl);
                    response.EnsureSuccessStatusCode(); // Throw exception for bad status codes
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response
                    var root = JsonConvert.DeserializeObject<Root>(responseBody);
                    root.keyword = keyword;
                    if (root._embedded == null) { root._embedded = new EmbeddedModel(); }
                    return View(root);
                }
                catch (HttpRequestException ex)
                {
                    // Handle API request errors
                    return View("Error", ex);
                }
            }
        }

        public async Task<IActionResult> AttDetails(string AttractionId, string imageUrl)
        {
            // Construct the events URL with parameters
            string eventUrl = $"{_baseUrl}events.json?attractionId={AttractionId}&apikey={_apiKey}&size=20";
            string attractionUrl = $"{_baseUrl}attractions/{AttractionId}.json?apikey={_apiKey}&size=20";

            // Make the API request
            using (var client = new HttpClient())
            {
                try
                {
                    //Get attraction data
                    HttpResponseMessage response = await client.GetAsync(attractionUrl);
                    response.EnsureSuccessStatusCode(); // Throw exception for bad status codes
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response
                    var attraction = JsonConvert.DeserializeObject<AttractionModel>(responseBody);

                    //Get event data for attraction
                    response = await client.GetAsync(eventUrl);
                    response.EnsureSuccessStatusCode(); // Throw exception for bad status codes
                    responseBody = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response
                    var eventResponse = JsonConvert.DeserializeObject<Root>(responseBody);

                    //Add attraction data to even response
                    //FYI: ticketmaster returns event request with attraction element blank
                    eventResponse.attraction = attraction;

                    return View(eventResponse);
                }
                catch (HttpRequestException ex)
                {
                    // Handle API request errors
                    return View("Error", ex);
                }
                catch (Exception ex)
                {
                    // log the error somewhere could offer explantion to user or maybe just return no data
                    return View(new Root());
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
