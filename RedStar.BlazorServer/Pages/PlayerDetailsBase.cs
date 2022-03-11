using Microsoft.AspNetCore.Components;
using RedStar.BlazorServer.Service;
using RedStar.Models;
using System.Threading.Tasks;

namespace RedStar.BlazorServer.Pages
{
    public class PlayerDetailsBase: ComponentBase
    {
        public Player Player { get; set; } = new Player();
        
        [Inject]
        public IPlayerService PlayerService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
             Player = await PlayerService.GetPlayer(int.Parse(Id));
        }
    }
}
