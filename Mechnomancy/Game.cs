namespace Mechnomancy
{
    public class Game
    {
        public IList<String> Deck { get; } = [];

        public Game() { 
            for (int card = 0; card < 10; card++)
            {
                if(card < 7)
                {
                    Deck.Add("Pyromana");
                }
                else
                {
                    Deck.Add("Slug");
                }
            }
        }
    }
}
