namespace game.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;           
        }
           public override string Attack(){
            return this.Name + " Lançou Magia";
        }   
    }
}