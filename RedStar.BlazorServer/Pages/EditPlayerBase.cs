using Microsoft.AspNetCore.Components;
using RedStar.BlazorServer.Service;
using RedStar.Models;
using System.Threading.Tasks;

namespace RedStar.BlazorServer.Pages
{
    public class EditPlayerBase: ComponentBase
    {
        [Inject]
        public IPlayerService PlayerService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Player Player { get; set; } = new Player();

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Player = await PlayerService.GetPlayer(int.Parse(Id));
        }

        protected async Task HandleSubmit()
        {
            var result = await PlayerService.UpdatePlayer(Player);

            if(result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected async Task DeleteClick()
        {
            await PlayerService.DeletePlayer(Player.Id);
            NavigationManager.NavigateTo("/");
        }
    }
}
