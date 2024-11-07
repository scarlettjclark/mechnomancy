namespace Mechnomancy
{
    public class Player
    {
        public IList<Card> Deck { get; private set; }
        public int Pyromana { get; set; } = 0;

        
        public Player() {
            Deck = new StartingDeck();
        }

        public Player(IList<Card> startingDeck)
        {
            Deck = startingDeck;
        }

        public void Draw(int cardsDrawn)
        {
            for (int card = 0; card < cardsDrawn; card++)
            {
                Deck.RemoveAt(0);
            }
        }
    }
}
