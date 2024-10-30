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

        [TestCase(11)]
        public void Draw_DrawingMoreCardsThanAreInDeckAndDiscardThrowsException_ThrowsOutOfRangeException(int cardsDrawn)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _game.Draw(cardsDrawn));
        }

        [Test]
        public void Play_PlayRemovesCardFromHand_HandCountDecrements()
        {
            _game.Draw(5);
            int handSize = _game.Hand.Count;
            _game.Play();
            Assert.That(_game.Hand.Count, Is.EqualTo(handSize - 1));
        }

        [Test]
        public void Play_PlayingWithAnEmptyHandThrowsException_ThrowsOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _game.Play());
        }

        [Test]
        public void Play_PlayingAddsCardToDiscardPile_DiscardPileCountIncrements()
        {
            _game.Draw(5);
            int discardPileSize = _game.DiscardPile.Count;
            _game.Play();
            Assert.That(_game.DiscardPile.Count, Is.EqualTo(discardPileSize + 1));
        }
    }
}