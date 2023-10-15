using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourOfHeroes.Models;
using TourOfHeroes.Services;

namespace TourOfHeroes.Pages
{
    public class SearchModel : PageModel
    {
        private readonly IHeroService _heroService;
        public SearchModel(IHeroService heroService)
        {
            _heroService = heroService;
        }

        public IEnumerable<Hero> Heroes { get; set; } = new List<Hero>();

        public async Task OnGet(string? search)
        {
            if (search != null)
            {
                Heroes = await _heroService.SearchHeroesAsync(search);
            }
        }
    }
}
