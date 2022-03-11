using Microsoft.AspNetCore.Components;
using RedStar.BlazorServer.Service;
using RedStar.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStar.BlazorServer.Pages
{
    public class PlayerListBase : ComponentBase
    {

        [Inject]
        public IPlayerService PlayerService { get; set; }

        public IEnumerable<Player> Players { get; set; }

        protected override async Task OnInitializedAsync()
        {

            Players = (await PlayerService.GetPlayers()).ToList();
        }

    }  

}
