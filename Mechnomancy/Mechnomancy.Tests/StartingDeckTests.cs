using System.Runtime.ExceptionServices;

namespace Mechnomancy.Tests
{
    public class StartingDeckTests
    {
        StartingDeck _deck;
        Card[] _preShuffle;
        Card[] _postShuffle;
        [SetUp]
        public void SetUp()
        {
            _deck = new();
            _preShuffle = new Card[_deck.Count];
            _deck.CopyTo(_preShuffle);
            _deck.Shuffle();
            _postShuffle = new Card[_deck.Count];
            _deck.CopyTo(_postShuffle);
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

        [Test]
        public void Deck_ShufflingTheDeckMaintainsDeckCount_TwoShuffledDecksHaveSameNumberOfCards()
        {
            Assert.That(_preShuffle.Length, Is.EqualTo(_postShuffle.Length));
        }
        [Test]
        public void Deck_ShufflingTheDeckChangesTheOrderWithProbabilityAtLeastNinetyNinePercent_PreShuffleSequenceNotEqualToPostShuffleSequence()
        {
            Assert.IsFalse(_preShuffle.SequenceEqual(_postShuffle));
        }
    }
}