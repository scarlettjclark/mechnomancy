namespace Mechnomancy
{
    public class Game
    {
        public StartingDeck Deck { get; private set; }
        
        public Game() {
            Deck = new StartingDeck();
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
