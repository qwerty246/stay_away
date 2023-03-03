using Cards;

namespace Players
{
    public abstract class Player
    {
        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private Deck _cards;

        public int Id { get; }
        public string? Name { get; }

        public enum InfectionStatus
        {
            Healthy,
            Thing,
            Infected
        }
    }
}
