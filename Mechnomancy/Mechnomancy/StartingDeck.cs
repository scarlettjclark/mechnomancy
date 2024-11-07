using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public class StartingDeck : List<Card>
    {
        public StartingDeck() {
            for (int i = 0; i < 10; i++)
            {
                if (i < 7)
                {
                    Add(new Card("Pyromana"));
                }
                else
                {
                    Add(new Card("Slug"));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            Card[] sequence = this.ToArray();
            random.Shuffle(sequence);
            this.Clear();
            foreach(Card card in sequence)
            {
                this.Add(card);
            }
        }
    }
}
