using DbLibrary.Models;
using DbLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApiServices;

namespace WebApp.Pages
{
    public class CreateModel(ReviewsApiService service) : PageModel
    {
        private readonly ReviewsApiService _service = service;
        [BindProperty]
        public Review Review { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
