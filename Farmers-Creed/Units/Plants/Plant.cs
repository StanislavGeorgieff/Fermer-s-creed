namespace FarmersCreed.Units.Plants
{
    using System;

    public abstract class Plant : FarmUnit
    {
        internal Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
        }

        public bool HasGrown
        {
            get {
                if (this.GrowTime<0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int GrowTime
        {
            get; set;
        }

        public virtual void Water()
        {
            this.Health += 2;
        }

        public virtual void Wither()
        {
            this.Health -= 1;
        }

        public virtual void Grow()
        {
            GrowTime--;
        }
    }
}
