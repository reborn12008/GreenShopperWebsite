using GreenShopperWebsite.Helper;
using GreenShopperWebsite.Models.APIModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GreenShopperWebsite.Controllers
{
    public class ShoplistController : Controller
    {
        GreenProducts _api = new GreenProducts();
        Models.WebsiteGreenShopContext _localdb = new Models.WebsiteGreenShopContext();
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAPIGreenList(List<String> item_input, String supermarketSelected)
        {
            List<List<Product>> betterProducts = new List<List<Product>>();
            for (int i = 0; i< item_input.Count(); i++)
            {
                List<Product> products = new List<Product>();
                HttpClient client = _api.Initial();
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibWFyaWF3THVpc2EyMiIsImp0aSI6ImFiNTNjNDc5LTBiNjEtNDk5Mi1iYWIxLTI3MjQ1ZGUyMjc3YiIsImV4cCI6MTYxMzMyMDY0MCwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzNTgifQ.NyH8fS-8xZT80B1mu14_cRvMB0uaQDi7QDS6IB9ZleA");
                HttpResponseMessage responseMessage = await client.GetAsync("api/Products/" + supermarketSelected + "/" + item_input[i] + "/makegreen");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var result = responseMessage.Content.ReadAsStringAsync().Result;
                    products = JsonConvert.DeserializeObject<List<Product>>(result);
                    betterProducts.Add(products);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(responseMessage);
                }
            }
            return View(betterProducts);
        }

        public async Task<List<Supermarket>> GetAllSupermarkets()
        {
            List<Supermarket> supermarkets = new List<Supermarket>();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Supermarkets");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                supermarkets = JsonConvert.DeserializeObject<List<Supermarket>>(result);
            }

            return supermarkets;
        }

        public async Task<List<Product>> GetProductsHints(String input, String supermarket)
        {
            List<Product> products = new List<Product>();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Products/producthints/" + supermarket + "/" + input);
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                products = JsonConvert.DeserializeObject<List<Product>>(result);
            }
            return products;
        }

        public async Task<IActionResult> SaveShoplist(List<String> shopList)
        {
            Models.Shoplist newShopList = new Models.Shoplist();
            var user_id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            newShopList.UserId = user_id;
            newShopList.ImactDescricao = DateTime.Now.Date.ToString();
            _localdb.Shoplists.Add(newShopList);
            await _localdb.SaveChangesAsync();
            var shoplist_id = newShopList.ShoplistId;
            foreach (String product in shopList)
            {
                List<Models.Product> productExistsinDb = await _localdb.Products.Where(p => p.ApiProductId == product).ToListAsync();
                Models.Product current_product = new Models.Product();
                if (productExistsinDb.Count() == 0)
                {
                    Models.Product newShopListProduct = new Models.Product();
                    newShopListProduct.ApiProductId = product;
                    await _localdb.Products.AddAsync(newShopListProduct);
                    await _localdb.SaveChangesAsync();
                    current_product = newShopListProduct;
                }
                else
                {
                    current_product = productExistsinDb[0];
                }

                Models.ShoplistProduct addProductToShopList = new Models.ShoplistProduct();
                addProductToShopList.ProductId = current_product.ProductId;
                addProductToShopList.ShoplistId = shoplist_id;
                await _localdb.ShoplistProducts.AddAsync(addProductToShopList);
                await _localdb.SaveChangesAsync();
                
                System.Diagnostics.Debug.WriteLine("PRODUTO ESCOLHIDO" + product);
            }
            return View();
        }

        public async Task<IActionResult> GetAllUserShoplists()
        {
            var user_id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Models.Shoplist> userShopLists = await _localdb.Shoplists.Where(sp => sp.UserId == user_id).ToListAsync();
            if (userShopLists.Count() == 0)
            {
                ViewData["no_shoplist"] = "You have not saved any shop lists in your account";
            }
            return View(userShopLists);
        }


        public async Task<IActionResult> GetShoplistProducts(int shoplistId)
        {
            List<Product> products = new List<Product>();
            List<Models.ShoplistProduct> productsOfList = await _localdb.ShoplistProducts.Where(sp=> sp.ShoplistId == shoplistId).ToListAsync();
            foreach (Models.ShoplistProduct shoplistProduct in productsOfList)
            {
                List<Models.Product> currentShoplistProduct = await _localdb.Products.Where(p => p.ProductId == shoplistProduct.ProductId).ToListAsync();

                HttpClient client = _api.Initial();
                HttpResponseMessage responseMessage = await client.GetAsync("api/Products/" + currentShoplistProduct[0].ApiProductId);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var result = responseMessage.Content.ReadAsStringAsync().Result;
                    products.Add(JsonConvert.DeserializeObject<Product>(result));
                }
            }
            ViewData["shoplist_id"] = shoplistId;
            return PartialView(products);
        }
    }

}
