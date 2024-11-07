namespace Mechnomancy.Tests
{
    public class RototurretTests
    {
        [Test]
        public void Health_RototurretStartsWithCorrectHealth_ReturnsFive()
        {
            Rototurret rototurret = new();
            Assert.That(rototurret.Health, Is.EqualTo(5));
        }
    }
}
