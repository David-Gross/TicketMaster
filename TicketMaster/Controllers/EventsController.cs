//using Microsoft.AspNetCore.Mvc;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using System.Collections.Generic;
//using TicketMaster.Models;

//namespace TicketMaster.Controllers
//{
//    public class EventsController : Controller
//    {
//        private readonly string _apiKey = "Ve0GnDy9niAOUWMpkMKwj49c7bdVdbMK"; 
//        private readonly string _baseUrl = "https://app.ticketmaster.com/discovery/v2/events.json";

//        public async Task<IActionResult> Index()
//        {
//            // Construct the API URL with parameters
//            string url = $"{_baseUrl}?apikey={_apiKey}&size=20"; 

//            // Make the API request
//            using (var client = new HttpClient())
//            {
//                try
//                {
//                    HttpResponseMessage response = await client.GetAsync(url);
//                    response.EnsureSuccessStatusCode(); // Throw exception for bad status codes
//                    string responseBody = await response.Content.ReadAsStringAsync();

//                    // Deserialize the JSON response
//                    var eventsResponse = JsonConvert.DeserializeObject<EventsModel>(responseBody);

//                    // Pass the events to the view
//                    return View(eventsResponse);
//                }
//                catch (HttpRequestException ex)
//                {
//                    // Handle API request errors
//                    return View("Error", ex);
//                }
//            }
//        }
//    }
//}

