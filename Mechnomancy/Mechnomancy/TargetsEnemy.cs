using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public abstract class TargetsEnemy : Card
    {
        public TargetsEnemy(string Name) : base(Name) { }
        public abstract void Play(IEnemy enemy);
    }
}
