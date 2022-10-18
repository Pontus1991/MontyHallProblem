using Microsoft.AspNetCore.Mvc;
using MontyHallProblem.Services;

namespace MontyHallProblem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IGetPlayers _getPlayers;
        private readonly IRandomizeEntities _randomizeEntities;

        public PlayersController(IGetPlayers getPlayers, IRandomizeEntities randomizeEntities)
        {
            _getPlayers = getPlayers;
            _randomizeEntities = randomizeEntities;
        }

        // GET: api/<PlayersController>
        [HttpGet("/players")]
        public IActionResult GetPlayers()
        {
            // Hämta den returnerade listan från servicesmetoden
            var users = _getPlayers.generateListOfPlayers();
            return Ok(users);
        }

        // GET: api/<PlayersController>
        [HttpGet("/entities")]
        public IActionResult GetRandomizedEntities()
        {
            // Hämta den returnerade listan från servicesmetoden
            var entities = _randomizeEntities.RandomizeEntity();
            return Ok(entities);
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
