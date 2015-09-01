namespace FarmersCreed.Units.Products
{
    using System;
    using FarmersCreed.Interfaces;

    public class Food : Product, IEdible
    {
        private FoodType foodType;
        private int healthEffect;

        public Food(string id, ProductType productType, FoodType foodType, int quantity, int healthEffect)
            : base(id, productType, quantity)
        {
            this.HealthEffect = healthEffect;
            this.FoodType = foodType;
        }

        public FoodType FoodType
        {
            get { return this.foodType; }
            set { this.foodType = value;  }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            set { this.healthEffect = value; }
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            string name = this.Id;
            int quantity =this.Quantity;
            string productType = this.ProductType.ToString();
            string foodType = this.FoodType.ToString();
            int healthEffect =  this.HealthEffect;
            string result= String.Format("--{0} {1}, Quantity: {2}, Product Type: {3}, Food Type: {4}, Health Effect: {5}", type, name, quantity, productType, foodType, healthEffect);
            return result;
        }
    }
}
