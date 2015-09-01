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
            get
            {
                if (this.GrowTime <= 0)
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
            get;
            set;
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

        public override string ToString()
        {
            string type = this.GetType().Name;
            string name = this.Id;
            int health = this.Health;
            string grown = (this.HasGrown) ? "Yes" : "No";
            string result;
            if (this.IsAlive==false)
            {
                result = String.Format("--{0} {1}, DEAD", type, name);
                return result;
            }
            else
            {
                result = string.Format("--{0} {1}, Health: {2}, Grown: {3}", type, name, health, grown);
                return result;
            }
        }
    }
}
