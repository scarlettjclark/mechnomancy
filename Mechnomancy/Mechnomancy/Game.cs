namespace Mechnomancy
{
    public class Game
    {
        public StartingDeck Deck { get; private set; }
        
        public Game() {
            Deck = new StartingDeck();
        }
    }
}
