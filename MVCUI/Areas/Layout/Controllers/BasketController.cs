using Dtos.Concrete.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MVCUI.Areas.Layout.Models;
using MVCUI.Areas.Layout.Services;
using MVCUI.Models;
using NToastNotify;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace MVCUI.Areas.Layout.Controllers
{
    [Area("Layout")]
    public class BasketController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        private readonly IToastNotification _toastNotification;
        private readonly CartManager cartManager;
        public BasketController(HttpClient httpClient, IOptions<AppConfigReadModel> config, IToastNotification toastNotification, CartManager cartManager)
        {
            _httpClient = httpClient;
            _Config = config.Value;
            _toastNotification = toastNotification;
            this.cartManager = cartManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var BasketItems = cartManager.GetAllItems();
            return View(BasketItems);
        }


        [HttpPost]
        public async Task<IActionResult> Add(int Id)
        {
            var response = await _httpClient.GetAsync($"{_Config.BaseUrl}/products/{Id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var productList = JsonSerializer.Deserialize<ListProductDto>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                cartManager.AddToCart(new Models.CartItem
                {
                    Id = productList.Id,
                    ProductPrice = productList.ProductPrice,
                    ProductName = productList.ProductName,
                    Quantity = 1,
                    TotalLinePrice = productList.ProductPrice * 1

                });

                _toastNotification.AddSuccessToastMessage("Sepete eklendi");
                return RedirectToAction("Index");

            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                _toastNotification.AddErrorToastMessage("Aradığınız ürün bulunamadı");
                return RedirectToAction("Index");
            }


            _toastNotification.AddErrorToastMessage($"Bir Hata ile karşılaşıldı : Durum : {response.StatusCode} {response.RequestMessage}");
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Update(List<CartItemUpdateDto> cartItems)
        {
            cartManager.UpdateCartItemBulkInsert(cartItems);
            
            _toastNotification.AddSuccessToastMessage("Sepet güncellendi eklendi");
            return RedirectToAction("Index", "Home");
        }


    }
}
