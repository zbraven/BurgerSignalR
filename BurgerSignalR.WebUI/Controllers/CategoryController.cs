
using BurgerSignalR.WebUI.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BurgerSignalR.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44319/api/Category"); //Api'nin hangisinden gelecek talebi seçeceğime karar verdim.
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();  //Gelen içeriği string formatında oku.
                var  values= JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);  //Json datasını çözüp normal metine dönüştürüyorum.(Listelerken Deserialize, güncellerken-eklerken Serialize)
                return View(values);
            }

            return View();
        }
    }
}
