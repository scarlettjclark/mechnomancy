namespace Mechnomancy
{
    public class Player
    {
        public IList<Card> Deck { get; private set; }
        public IList<Card> Hand { get; private set; }
        public IList<Card> DiscardPile { get; private set; }
        public int Pyromana { get; set; } = 0;

        public Player(IList<Card> startingDeck)
        {
            Deck = startingDeck;
            Hand = [];
            DiscardPile = [];
        }

        public void Draw(int cardsDrawn)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(Deck.Count + DiscardPile.Count, cardsDrawn);
            for (int card = 0; card < cardsDrawn; card++)
            {
                if (Deck.Count == 0)
                {
                    foreach (Card discardedCard in DiscardPile)
                    {
                        Deck.Add(discardedCard);
                        
                    }
                    DiscardPile.Clear();
                }
                Hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
        }

        public void Discard()
        {
            DiscardPile.Add(Hand[0]);
            Hand.RemoveAt(0);
        }
    }
}
