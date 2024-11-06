namespace Mechnomancy.Tests
{
    public class GameTests
    {
        Game _game;
        IEnumerable<Object> _deck;
        [SetUp]
        public void SetUp() 
        { 
            _game = new();
            _deck = _game.Deck;
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Deck_DrawingCardsReducesCardsInDeckByThatAmount_DeckCountDecrements(
                int cardsDrawn
            )
        {
            int initialDeckCount = _deck.Count();
            _game.Draw(cardsDrawn);
            Assert.That(_deck.Count, Is.EqualTo(initialDeckCount - cardsDrawn));
        }
        [Test]
        public void Deck_DrawingMoreCardsThanInDeckResultsInException_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _game.Draw(_deck.Count() + 1));
        }
    }
}
