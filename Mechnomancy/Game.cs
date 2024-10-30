namespace Mechnomancy
{
    public class Game
    {
        public IList<Object> Deck { get; } = [];
        public IList<Object> Hand { get; } = [];

        public Game() { 
            for (int card = 0; card < 10; card++)
            {
                Object cardToBeAdded;
                if(card < 7)
                {
                    cardToBeAdded = new Pyromana();
                }
                else
                {
                    cardToBeAdded = "Slug";
                }
                Deck.Add(cardToBeAdded);
            }
        }

        public void Draw(int cards)
        {
            for(int card = 0; card < cards; card++)
            {
                Hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
        }
    }
}
