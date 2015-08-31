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

        public virtual  void Eat(IEdible food, int quantity)
        {
            throw new NotImplementedException();
        }

        public virtual void Starve()
        {
            this.Health -= 1;
        }
    }
}
