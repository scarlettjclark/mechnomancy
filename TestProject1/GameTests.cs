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
            IEnumerable<Object> pyromanas = _game.Deck.Where(card => card.ToString() == "Pyromana");
            Assert.That(pyromanas.Count, Is.EqualTo(7));
        }

        [Test]
        public void GameInit_DeckStartsWithThreeSlugs_SlugCountInDeckIsThree()
        {
            IEnumerable<Object> slugs = _game.Deck.Where(card => card.ToString() == "Slug");
            Assert.That(slugs.Count, Is.EqualTo(3));
        }

        [Test]
        public void GameInit_HandStartsEmpty_HandCountIsZero()
        {
            Assert.That(_game.Hand.Count, Is.EqualTo(0));
        }


        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Draw_DrawingAddsCardsToHand_HandCountMatchesCardsDrawn(
            int cardsDrawn)
        {
            _game.Draw(cardsDrawn);
            Assert.That(_game.Hand.Count, Is.EqualTo(cardsDrawn));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Draw_DrawingRemovesCardsFromDeck_DeckCountIsInitialDeckCountMinusCardsDrawn(
            int cardsDrawn)
        {
            int initialDeckCount = _game.Deck.Count;
            _game.Draw(cardsDrawn);
            Assert.That(_game.Deck.Count, Is.EqualTo(initialDeckCount - cardsDrawn));
        }
    }
}