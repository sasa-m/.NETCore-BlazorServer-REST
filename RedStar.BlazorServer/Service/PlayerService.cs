using Microsoft.AspNetCore.Components;
using RedStar.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RedStar.BlazorServer.Service
{
    public class PlayerService: IPlayerService
    {
        private readonly HttpClient httpClient;

        public PlayerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task DeletePlayer(int id)
        {
            await httpClient.DeleteAsync($"api/players/{id}");
        }

        public async Task<Player> GetPlayer(int id)
        {
            return await httpClient.GetJsonAsync<Player>($"api/players/{id}");
        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            return await httpClient.GetJsonAsync<Player[]>("api/players");
        }

        public async Task<Player> UpdatePlayer(Player updatedPlayer)
        {
            return await httpClient.PutJsonAsync<Player>("api/players", updatedPlayer);
        }
    }
}
