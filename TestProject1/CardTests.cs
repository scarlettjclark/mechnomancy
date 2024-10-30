using Mechnomancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechnomancyTests
{
    internal class PyromanaTests
    {
        [Test]
        public void Play_PlayingPyromanaIncrementsPlayersPyromanaByOne_PyromanaIncreasesByOneAfterPlay()
        {
            IPlayer player = new Player();
            Pyromana pyromana = new();
            int initPyromana = player.Pyromana;
            pyromana.Play(player);
        }

    }
}
