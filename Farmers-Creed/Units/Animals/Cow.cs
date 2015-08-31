using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;
using FarmersCreed.Units.Plants;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Units.Animals
{
    class Cow : Animal
    {
        public Cow(string id)
            : base(id, 15, 6)
        {
        }

        public override Product GetProduct()
        {
            this.Health -= 2;
            return new Food(this.Id + "Product", ProductType.Milk, FoodType.Organic, this.ProductionQuantity, 4);
        }

        public override void Eat(IEdible food, int quantity)
        {
            if (this.IsAlive == true)
            {
                if (food.FoodType == FoodType.Organic)
                {
                    this.Health += food.HealthEffect * quantity;
                }

                else
                {
                    this.Health -= food.HealthEffect * quantity;
                }

            }

            else
            {
                throw new InvalidOperationException("The cow is dead!");
            }

        }
    }
}
