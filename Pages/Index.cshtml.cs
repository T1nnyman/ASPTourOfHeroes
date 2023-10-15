using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourOfHeroes.Models;
using TourOfHeroes.Services;

namespace TourOfHeroes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHeroService _heroService;
        public IndexModel(IHeroService heroService)
        {
            _heroService = heroService;
        }

        public IEnumerable<Hero> Heroes { get; set; } = new List<Hero>();

        public async Task OnGet()
        {
            Heroes = await _heroService.GetHeroesAsync(4);
        }
    }
}