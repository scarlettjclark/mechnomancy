using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public abstract class Card : ICard
    {
        public String Name { get; set; }
        public abstract void Play(IPlayer player);

        public Card()
        {
            Name = "";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
