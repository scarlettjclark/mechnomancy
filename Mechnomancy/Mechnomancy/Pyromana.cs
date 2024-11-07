using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public class Pyromana : TargetsSelf
    {
        public Pyromana() : base("Pyromana")
        {

        }
        public override void Play(Player player)
        {
            player.Pyromana += 1;
        }

    }
}
