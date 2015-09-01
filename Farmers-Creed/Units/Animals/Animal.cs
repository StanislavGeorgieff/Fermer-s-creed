namespace FarmersCreed.Units.Plants
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit
    {
        public Animal(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {
        }

        public abstract void Eat(IEdible food, int quantity);
     

        public virtual void Starve()
        {
            this.Health -= 1;
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            string name = this.Id;
            int health = this.Health;
            string result;
            if (this.IsAlive==false)
            {
                result = String.Format("--{0} {1}, DEAD", type, name);
                return result;
            }
            else
            {
                result = String.Format("--{0} {1}, Health: {2}", type, name, health);
                return result;
            }
        }
    }
}
