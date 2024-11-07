namespace Mechnomancy.Tests
{
    public class PlayerTests
    {
        Player _player;
        IEnumerable<Object> _deck;
        [SetUp]
        public void SetUp() 
        { 
            _player = new Player(new StartingDeck());
            _deck = _player.Deck;
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Deck_DrawingCardsReducesCardsInDeckByThatAmount_DeckCountDecrements(
                int cardsDrawn
            )
        {
            int initialDeckCount = _deck.Count();
            _player.Draw(cardsDrawn);
            Assert.That(_deck.Count, Is.EqualTo(initialDeckCount - cardsDrawn));
        }
        [Test]
        public void Deck_DrawingMoreCardsThanInDeckResultsInException_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _player.Draw(_deck.Count() + 1));
        }

        [Test]
        public void Pyromana_PyromanaStartsAtZero_ReturnsZero()
        {
            Assert.That(_player.Pyromana, Is.EqualTo(0));
        }
    }
}
