using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy
{
    public class Slug : TargetsEnemy
    {
        public Slug() : base("Slug")
        {

        }

        public override void Play(IEnemy enemy)
        {
            enemy.Health--;
        }
    }
}
