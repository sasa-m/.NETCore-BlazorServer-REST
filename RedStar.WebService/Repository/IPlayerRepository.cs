using RedStar.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedStar.WebService.Repository
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetPlayers();

        Task<Player> GetPlayer(int playerId);

        //Task<Player> AddPlayer(Player player);

        Task<Player> UpdatePlayer(Player player);

        Task<Player> DeletePlayer(int playerId);
    }
}
