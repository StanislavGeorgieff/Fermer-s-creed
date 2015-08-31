using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;
using FarmersCreed.Units.Plants;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Units.Animals
{
    class Swine : Animal
    {
        public Swine(string id)
            : base(id, 20, 1)
        {
        }

        public override void Eat(IEdible food, int quantity)
        {
            if (IsAlive == true)
            {
                Health += 2 * food.HealthEffect;
            }
            else
            {
                throw new InvalidOperationException("The swine is dead!");
            }
        }

        public override Product GetProduct()
        {
            if (IsAlive == true)
            {
                this.Health = 0;
                return new Food(this.Id + "Product", ProductType.PorkMeat, FoodType.Meat, 5, this.ProductionQuantity);
            }
            else
            {
                throw new InvalidOperationException("The swine is dead!");
            }
        }

        public override void Starve()
        {
            for (int i = 0; i < 3; i++)
            {
                base.Starve();
            }

        }
    }
}
