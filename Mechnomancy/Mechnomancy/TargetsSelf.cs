using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public abstract class TargetsSelf : Card
    {
        public TargetsSelf(string name) : base(name)
        {

        }
        public abstract void Play(Player player);
    }
}
