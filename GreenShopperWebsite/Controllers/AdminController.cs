using GreenShopperWebsite.Helper;
using GreenShopperWebsite.Models.APIModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GreenShopperWebsite.Controllers
{
    public class AdminController : Controller
    {
        GreenProducts _api = new GreenProducts();

        public IActionResult InsertDataIndex()
        {
            return View();
        }

        public IActionResult ViewDataIndex()
        {
            return View();
        }

        public async Task<IActionResult> CreateSupermarket()
        {
            return View();
        }

        public async Task<IActionResult> ViewSupermarkets()
        {
            List<Supermarket> supermarkets = new List<Supermarket>();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Supermarkets");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                supermarkets = JsonConvert.DeserializeObject<List<Supermarket>>(result);
            }
            return View(supermarkets);
        }
    }
}
