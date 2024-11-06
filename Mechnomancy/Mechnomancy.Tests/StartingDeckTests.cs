namespace Mechnomancy.Tests
{
    public class StartingDeckTests
    {
        StartingDeck _deck;
        [SetUp]
        public void SetUp()
        {
            _deck = new();
        }
        [Test]
        public void Deck_ContainsTenObjectsToStartWith_ReturnsTen()
        {
            Assert.That(_deck.Count, Is.EqualTo(10));
        }

        [Test]
        public void Deck_SevenOfTheCardsInTheDeckArePyromana_SevenPyromanaStringInDeck()
        {
            IEnumerable<Object> pyromanas = _deck.Where(card => card.ToString() == "Pyromana");
            Assert.That(pyromanas.Count, Is.EqualTo(7));
        }
    }
}