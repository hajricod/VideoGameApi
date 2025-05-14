using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>()
        {
            new VideoGame
            {
                Id = 1,
                Title = "Test",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony",
            },
            new VideoGame
            {
                Id = 2,
                Title = "Test",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony",
            },
            new VideoGame
            {
                Id = 3,
                Title = "Test",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony",
            }
        };

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public ActionResult<VideoGame> GetVideoGameById(int id)
        {
            var videoGame = videoGames.FirstOrDefault(g => g.Id == id);
            if (videoGame == null)
                return NotFound();
            return Ok(videoGame);
        }

        [HttpPost]
        public ActionResult<VideoGame> AddVideoGame(VideoGame newGame)
        {
            if (newGame == null)
                return BadRequest();

            newGame.Id = videoGames.Max(g => g.Id) + 1;
            videoGames.Add(newGame);
            return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideoGame(int id, VideoGame updatedGame)
        {
            var game = videoGames.FirstOrDefault(g => g.Id == id);
            if (game == null)
                return NotFound();
            game.Title = updatedGame.Title;
            game.Platform = updatedGame.Platform;
            game.Publisher = updatedGame.Publisher;
            game.Developer = updatedGame.Developer;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideoGame(int id)
        {
            var game = videoGames.FirstOrDefault(g => g.Id == id);
            if(game == null)
                return NotFound();

            videoGames.Remove(game);
            return NoContent();
        }
    }
}
