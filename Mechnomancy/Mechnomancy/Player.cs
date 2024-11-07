namespace Mechnomancy
{
    public class Player
    {
        public IList<Card> Deck { get; private set; }
        public IList<Card> Hand { get; private set; }
        public int Pyromana { get; set; } = 0;

        public Player(IList<Card> startingDeck)
        {
            Deck = startingDeck;
            Hand = [];
        }

        public void Draw(int cardsDrawn)
        {
            for (int card = 0; card < cardsDrawn; card++)
            {
                Hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
        }
    }
}
