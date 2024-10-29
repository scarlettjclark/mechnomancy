namespace Mechnomancy.Tests
{
    public class GameTests
    {
        Game _game;
        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void GameInit_DeckStartsOffWithTenCards_DeckCountIsTen()
        {
            Assert.That(_game.Deck.Count, Is.EqualTo(10));
        }

        [Test]
        public void GameInit_DeckStartsWithSevenPyromana_PyromanaCountInDeckIsSeven()
        {
            Assert.That(_game.Deck.Where(card => card.ToString() == "Pyromana").Count(), Is.EqualTo(7));
        }

        [Test]
        public void GameInit_DeckStartsWithThreeSlugs_SlugCountInDeckIsThree()
        {
            Assert.That(_game.Deck.Where(card => card.ToString() == "Slug").Count(), Is.EqualTo(3));
        }
    }
}