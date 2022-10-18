namespace MontyHallProblem.Services
{
    public class GetPlayers : IGetPlayers
    {
        public List<Player> generateListOfPlayers()
        {
            List<Player> playerList = new List<Player>() 
            { 
                new Player
                {
                    Id = 1,
                    Name = "Player 1"
                },
                new Player
                {
                    Id = 2,
                    Name = "Presenter"
                }
            };

            return playerList;
        }
    }
}
