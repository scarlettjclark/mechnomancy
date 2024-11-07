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
            _player.Draw(5);
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Draw_DrawingCardsReducesCardsInDeckByThatAmount_DeckCountDecrements(
                int cardsDrawn
            )
        {
            int initialDeckCount = _deck.Count();
            _player.Draw(cardsDrawn);
            Assert.That(_deck.Count, Is.EqualTo(initialDeckCount - cardsDrawn));
        }
        [Test]
        public void Draw_DrawingMoreCardsThanInDeckAndDiscardResultsInException_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _player.Draw(_deck.Count() +_player.DiscardPile.Count + 1));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Draw_DrawAddsThatManyCardsToHand_HandCountIncreasesByCardsDrawn(
            int cardsDrawn)
        {
            int initialHandCount = _player.Hand.Count();
            _player.Draw(cardsDrawn);
            Assert.That(_player.Hand.Count, Is.EqualTo(initialHandCount + cardsDrawn));
        }
        [Test]
        public void Draw_IfMoreCardsThanInDeckAreDrawnDeckIsReplenished_HandCountIsTen()
        {
            _player.Discard();
            _player.Draw(6);
            Assert.That(_player.Hand.Count, Is.EqualTo(10));
        }

        [Test]
        public void Discard_DiscardRemovesCardFromDeck_HandCountDecrements()
        {
            int initialHandCount = _player.Hand.Count;
            _player.Discard();
            Assert.That(_player.Hand.Count(), Is.EqualTo(initialHandCount - 1));
        }
        [Test]
        public void Discard_DiscardAddsCardToDiscardPile_DiscardPileCountIsOne()
        {
            int initialDiscardPileCount = _player.DiscardPile.Count;
            _player.Discard();
            Assert.That(_player.DiscardPile.Count, Is.EqualTo(initialDiscardPileCount + 1));

        }

        [Test]
        public void Pyromana_PyromanaStartsAtZero_ReturnsZero()
        {
            Assert.That(_player.Pyromana, Is.EqualTo(0));
        }
    }
}
