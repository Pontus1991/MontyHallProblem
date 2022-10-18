namespace MontyHallProblem.Services
{
    public class RandomizeEntities : IRandomizeEntities
    {
        public List<Entity> randomEntities = new List<Entity>();
        public List<Entity> RandomizeEntity()
        {
            randomEntities.Add(new Entity("Goat"));
            randomEntities.Add(new Entity("Goat"));
            randomEntities.Add(new Entity("Car"));

            var random = new Random();
            var result = randomEntities.OrderBy(x => random.Next());

            return randomEntities;
        }
    }
}

