using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW_1_Module_1_Part_1.Pages
{
    public class RestaurantModel : PageModel
    {
        public Restaurant Restaurant { get; set; }
        public void OnGet()
        {
            Restaurant = new Restaurant
            {
                Name = "Ресторан САСА",
                Address = "вул. Якась Така, 666, Кривий Ріг",
                PhoneNumber = "+380999999999",
                Description = "Супер Дупер Ресторан Таракани Пацюки Антисанітарія!!!",
                Cuisines = new[] { "Тараканська", "Пацюківська", "Мишина" },
                OpeningHours = new[] { "Пн-Пт: 10:00 - 22:00", "Сб-Нд: 12:00 - 23:00" }
            };
        }
    }
}
