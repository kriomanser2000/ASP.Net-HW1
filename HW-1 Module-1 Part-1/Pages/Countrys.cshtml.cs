using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;

namespace HW_1_Module_1_Part_1.Pages
{
    public class CountrysModel : PageModel
    {
        public List<Country> Countries { get; set; }
        public void OnGet()
        {
            Countries = new List<Country>
            {
                new Country
                {
                    Name = "Ukraine",
                    Capital = "Kyiv",
                    Population = 44130000,
                    Area = 603550
                },
                new Country
                {
                    Name = "United States",
                    Capital = "Washington, D.C.",
                    Population = 329484000,
                    Area = 9833517
                },
            };
        }
    }
}
