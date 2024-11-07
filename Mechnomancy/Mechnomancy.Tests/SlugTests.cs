namespace Mechnomancy.Tests
{
    public class SlugTests
    {
        public IEnemy _enemy;
        public Slug _slug;

        [SetUp]
        public void Setup()
        {
            _enemy = new Rototurret();
            _slug = new Slug();
        }

        [Test]
        public void Play_SlugDecrementsEnemyHealthByOne_EnemyHealthDecrements()
        {
            int initialHealth = _enemy.Health;
            _slug.Play(_enemy);
            Assert.That(_enemy.Health, Is.EqualTo(initialHealth-1));
        }

    }
}
