using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy.Tests
{
    public class CardTests
    {
        [Test]
        public void Name_NameIsSameAsToString_NameEqualsToString()
        {
            Card card = new Card("Pyromana");
            Assert.That(card.Name, Is.EqualTo(card.ToString()));
        }
    }
}
