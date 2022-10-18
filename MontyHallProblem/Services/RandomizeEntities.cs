namespace MontyHallProblem.Services
{
    public class RandomizeEntities : IRandomizeEntities
    {
        // Create a list of entities. 
        public List<Entity> randomEntities = new List<Entity>();
        public List<Entity> RandomizeEntity()
        {
            // Add goats and the car to the list.
            randomEntities.Add(new Entity("Goat"));
            randomEntities.Add(new Entity("Goat"));
            randomEntities.Add(new Entity("Car"));

            // Shuffle the list with "Random".
            var random = new Random();
            var result = randomEntities.OrderBy(x => random.Next());

            // Return the randomized list to use in the PlayersController.
            return result.ToList();
        }
    }
}

