using FarmersCreed.Interfaces;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable
    {
        public FarmUnit(string id, int health, int productionQuantity)
            : base(id)
        {
            this.Id = id;
            this.Health = health;
            this.ProductionQuantity = productionQuantity;
        }

        public int Health
        {
            get; set;
        }

        public bool IsAlive
        {
            get {
                if (this.Health<=0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public int ProductionQuantity
        {
            get; set; }

        public virtual Product GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}
