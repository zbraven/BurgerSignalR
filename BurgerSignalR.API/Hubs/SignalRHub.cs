using BurgerSignalR.DataAccessLayer;
using Microsoft.AspNetCore.SignalR;

namespace BurgerSignalR.API.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly BurgerContext _context;

        public SignalRHub(BurgerContext context)
        {
            _context = context;
        }

        public async Task SendCategoryCount()
        {
            var value = _context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
