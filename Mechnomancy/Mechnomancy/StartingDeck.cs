using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public class StartingDeck : List<string>
    {
        public StartingDeck() {
            for (int i = 0; i < 10; i++)
            {
                if (i < 7)
                {
                    Add("Pyromana");
                }
                else
                {
                    Add("Slug");
                }
            }
        }
    }
}
