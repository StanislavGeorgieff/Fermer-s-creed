using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units.Plants
{
    internal class FoodPlant : Plant
    {
        public FoodPlant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity, growTime)
        {
            this.Health += 1;
        }

        public override void Wither()
        {
            this.Health -= 2;
        }
    }
}
