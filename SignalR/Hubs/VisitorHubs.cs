using Microsoft.AspNetCore.SignalR;
using SignalR.Model;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class VisitorHubs : Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHubs(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", "bbb");
        }
    }
}
