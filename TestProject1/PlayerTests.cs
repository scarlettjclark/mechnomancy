namespace Mechnomancy.Tests
{
    class PlayerTests
    {
        [Test]
        public void PlayerInit_PlayerStartsWithZeroPyromana_PyromanaInitiallyZero()
        {
            Player player = new();
            Assert.That(player.Pyromana, Is.EqualTo(0));
        }
    }
}
