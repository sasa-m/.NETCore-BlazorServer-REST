using RedStar.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedStar.BlazorServer.Service
{
    public interface IPlayerService
    {
        Task<IEnumerable<Player>> GetPlayers();

        Task<Player> GetPlayer(int id);

        Task<Player> UpdatePlayer(Player updatedPlayer);

        Task DeletePlayer(int id);
    }
}
