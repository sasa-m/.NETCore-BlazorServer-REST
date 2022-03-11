using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedStar.Models;
using RedStar.WebService.Repository;
using System;
using System.Threading.Tasks;

namespace RedStar.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController: ControllerBase
    {
        private readonly IPlayerRepository playerRepository;

        public PlayersController(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetPlayers()
        {
            try
            {
                return Ok(await playerRepository.GetPlayers());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            try
            {
                var result = await playerRepository.GetPlayer(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }

        }

        //[HttpPost]
        //public async Task<ActionResult<Player>> CreatePlayer(Player player)
        //{
           // try
            //{
                //if (player == null)
                //{
                    //return BadRequest();
               // }

                //var createPlayer = await playerRepository.AddPlayer(player);

                //return CreatedAtAction(nameof(GetPlayer), new { id = createPlayer.Id }, createPlayer);

            //}
            //catch (Exception)
            //{

                //return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            //}
       // }

        [HttpPut]
        public async Task<ActionResult<Player>> UpdatePlayere(Player player)
        {
            try
            {

                var playerToUpdate = await playerRepository.GetPlayer(player.Id);

                if (playerToUpdate == null)
                {
                    return NotFound($"Player with Id = {player.Id} not found");
                }

                return await playerRepository.UpdatePlayer(player);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Player>> DeletePlayer(int id)
        {
            try
            {
                var playerToDelete = await playerRepository.GetPlayer(id);
                if (playerToDelete == null)
                {
                    return NotFound($"Player with Id = {id} not found");
                }

                return await playerRepository.DeletePlayer(id);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }

        }

    }
}
