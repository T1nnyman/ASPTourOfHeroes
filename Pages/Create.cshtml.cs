using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourOfHeroes.Models;
using TourOfHeroes.Services;

namespace TourOfHeroes.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IHeroService _heroService;

        public CreateModel(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [BindProperty]
        public string HeroName { get; set; }
    }
}
