namespace ProjetoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " lançou magia";
        }   

        public string Attack(int bonus)     
        {
            if (bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bonus de ataque " + bonus;
            }
            else
            {
                return this.Name + " lançou magia com força fraca com bonus de " + bonus;
            }
        }
    }
}