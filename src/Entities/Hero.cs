namespace ProjetoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }        

        public virtual string Attack()
        {
            return this.Name + " fez um ataque";
        }
    }
}