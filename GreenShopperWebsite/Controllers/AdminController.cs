using GreenShopperWebsite.Helper;
using GreenShopperWebsite.Models.APIModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GreenShopperWebsite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        GreenProducts _api = new GreenProducts();

        public IActionResult InsertDataIndex()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            System.Diagnostics.Debug.WriteLine("Id->" + id);
            Supermarket supermarket = new Supermarket();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync($"api/Supermarkets/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadFromJsonAsync<Supermarket>();
                System.Diagnostics.Debug.WriteLine("Resultado->" + result);
                supermarket = result;

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error->" + responseMessage);
            }
            return View(supermarket);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Supermarket supermarket)
        {
           
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync($"api/Supermarkets/{id}", supermarket);
            responseMessage.EnsureSuccessStatusCode();
            return View(supermarket);
        }

        public async Task<IActionResult> EditProduct(int id, float item_price, String supermarket, int supermarket_id, int supermaket_product)
        {
            Product product = new Product();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync($"api/Products/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadFromJsonAsync<Product>();
                System.Diagnostics.Debug.WriteLine("Resultado->" + result);
                product = result;

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error->" + responseMessage);
            }

            HttpResponseMessage typeRequest = await client.GetAsync("api/ImpactCategories");
            if (typeRequest.IsSuccessStatusCode)
            {
                var result = typeRequest.Content.ReadAsStringAsync().Result;
                ViewData["impact_categories"] = JsonConvert.DeserializeObject<List<ImpactCategory>>(result);
            }
            ViewData["price"] = item_price;
            ViewData["supermarket"] = supermarket;
            ViewData["supermarket_id"] = supermarket_id;
            ViewData["supermarket_product_id"] = supermaket_product;
            return View(product);
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {

            Product product = new Product();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.DeleteAsync($"api/Supermarket_Product/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                //var result = await responseMessage.Content.ReadFromJsonAsync<Product>();
                //System.Diagnostics.Debug.WriteLine("Resultado->" + result);
           
            }

            return RedirectToAction("ViewDataIndex");

        }

        [HttpPost]
        public async Task<IActionResult> EditProduct( int id, String item_price, int supermarket, Product product, int supermarket_product)
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync($"api/Products/{id}", product);
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            //responseMessage.EnsureSuccessStatusCode();
            if (!responseMessage.IsSuccessStatusCode)
            { System.Diagnostics.Debug.WriteLine("Resposta edit produto" + responseMessage); 
            }
            Product postedProduct = JsonConvert.DeserializeObject<Product>(result);

            Supermarket_Product updatedSpP = new Supermarket_Product();
            updatedSpP.ProductId = postedProduct.Id;
            updatedSpP.SupermarketId = supermarket;
            updatedSpP.Price = item_price;

            HttpResponseMessage update_price = await client.PutAsJsonAsync($"api/Supermarket_Product/{supermarket_product}", updatedSpP);
            //update_price.EnsureSuccessStatusCode();
            if (!responseMessage.IsSuccessStatusCode)
            {
                System.Diagnostics.Debug.WriteLine("Resposta edit preço" + update_price);
            }

            return RedirectToAction("ViewDataIndex");
        }

        public IActionResult ViewDataIndex()
        {
            return View();
        }

        public IActionResult CreateSupermarket()
        {
            return PartialView();
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
            return PartialView(supermarkets);
        }

        public async Task<IActionResult> ViewProducts()
        {
            List<Supermarket_Product> products = new List<Supermarket_Product>();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Supermarket_Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                products = JsonConvert.DeserializeObject<List<Supermarket_Product>>(result);
            }
            return PartialView(products);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage categoryRequest = await client.GetAsync("api/Categories");
            if (categoryRequest.IsSuccessStatusCode)
            {
                var result = categoryRequest.Content.ReadAsStringAsync().Result;
                ViewData["categories"] = JsonConvert.DeserializeObject<List<Category>>(result);
            }

            HttpResponseMessage typeRequest = await client.GetAsync("api/ImpactCategories");
            if (typeRequest.IsSuccessStatusCode)
            {
                var result = typeRequest.Content.ReadAsStringAsync().Result;
                ViewData["impact_categories"] = JsonConvert.DeserializeObject<List<ImpactCategory>>(result);
            }

            HttpResponseMessage supermarketsRequest = await client.GetAsync("api/Supermarkets");
            if (supermarketsRequest.IsSuccessStatusCode)
            {
                var result = supermarketsRequest.Content.ReadAsStringAsync().Result;
                ViewData["supermarkets"] = JsonConvert.DeserializeObject<List<Supermarket>>(result);
            }
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product, int supermarket_input, String price_input)
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage insertProduct = await client.PostAsJsonAsync("api/Products", product);
            price_input.Replace(",", ".");
            System.Diagnostics.Debug.WriteLine("PRICE GOING->" + price_input);
            if (insertProduct.IsSuccessStatusCode)
            {
                var posted_product = insertProduct.Content.ReadAsStringAsync().Result;
                Product insertedProduct = JsonConvert.DeserializeObject<Product>(posted_product);
                Supermarket_Product sp_p = new Supermarket_Product();
                sp_p.ProductId = insertedProduct.Id;
                sp_p.SupermarketId = supermarket_input;
                sp_p.Price = price_input;
                HttpResponseMessage sup_product_associate = await client.PostAsJsonAsync("api/Supermarket_Product", sp_p);
                if (!sup_product_associate.IsSuccessStatusCode)
                {
                    System.Diagnostics.Debug.WriteLine(sup_product_associate);
                }
            }
            
            return View("ProductCreated",product);
        }
    }
}
