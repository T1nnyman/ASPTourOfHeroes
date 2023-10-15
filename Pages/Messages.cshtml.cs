using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourOfHeroes.Services;

namespace TourOfHeroes.Pages
{
    public class MessagesModel : PageModel
    {
        private readonly IMessageService _messageService;
        public MessagesModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public List<string> Messages { get; set; } = new List<string>();

        public void OnGet(string? clear)
        {
            if (clear == "true")
            {
                _messageService.Clear(); _messageService.Clear();
            }
                
            Messages = _messageService.Messages.ToList();
        }
    }
}
