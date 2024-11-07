using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy.Tests
{
    public class RototurretTests
    {
        [Test]
        public void Health_RototurretStartsWithCorrectHealth_ReturnsFive()
        {
            Rototurret rototurret = new();
            Assert.That(rototurret.Health, Is.EqualTo(5));
        }
    }
}
