namespace Mechnomancy
{
    public class Pyromana : Card
    {
        public Pyromana()
        {
            Name = "Pyromana";
        }
        public override void Play(IPlayer player)
        {
            player.Pyromana++;
        }
    }
}
