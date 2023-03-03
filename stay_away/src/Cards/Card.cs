namespace Cards
{
    public class Card
    {
        public Card(int id, string name, bool isEvent, PlayerTarget target, PositionOnBoard pos)
        {
            Id = id;
            Name = name;
            IsEvent = isEvent;
            Target = target;

            Position = pos;
        }

        public int Id { get; }
        public string? Name { get; }
        public bool IsEvent { get; }
        public PlayerTarget Target { get; }
        public PositionOnBoard Position { get; set; }

        public enum PlayerTarget
        {
            PlayerHimself,
            NeighborPlayer,
            AnyPlayer
        }
        public enum PositionOnBoard
        {
            OnHand,
            InDeck,
            InDiscard_pile
        }
    }
}
