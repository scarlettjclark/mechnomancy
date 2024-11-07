using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechnomancy.Tests
{
    public class PyromanaTests
    {
        Pyromana _pyromana;
        [SetUp]
        public void SetUp()
        {
            _pyromana = new();
        }
        [Test]
        public void Name_PyromanaIsNamedPyromana_ReturnsStringPyromana()
        {
            Assert.That(_pyromana.Name, Is.EqualTo("Pyromana"));
        }

        [Test]
        public void Play_PyromanaAddsOneToThePlayersPyromana_PlayerPyromanaIncrements()
        {
            Player player = new Player();
            Pyromana pyromana = new Pyromana();
            int initialPyromana = player.Pyromana;
            pyromana.Play(player);
            Assert.That(player.Pyromana, Is.EqualTo(initialPyromana+1));
        }
    }
}
