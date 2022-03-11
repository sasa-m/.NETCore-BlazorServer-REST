using Microsoft.EntityFrameworkCore;
using RedStar.Models;
using RedStar.WebService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedStar.WebService.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly AppDbContext appDbContext;

        public PlayerRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //public async Task<Player> AddPlayer(Player player)
        //{
            //var result = await appDbContext.Players.AddAsync(player);
            //await appDbContext.SaveChangesAsync();
            //return result.Entity;
        //}

        public async Task<Player> DeletePlayer(int playerId)
        {
            var result = await appDbContext.Players.FirstOrDefaultAsync(e => e.Id == playerId);
            if (result != null)
            {
                appDbContext.Players.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Player> GetPlayer(int playerId)
        {
            return await appDbContext.Players.FirstOrDefaultAsync(e => e.Id == playerId);
        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            return await appDbContext.Players.ToListAsync();
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            var result = await appDbContext.Players.FirstOrDefaultAsync(e => e.Id == player.Id);

            if (result != null)
            {
                result.Number = player.Number;
                result.FirstName = player.FirstName;
                result.LastName = player.LastName;
                result.Position = player.Position;
                result.Height = player.Height;
                result.Born = player.Born;
                result.PhotoPath = player.PhotoPath;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
