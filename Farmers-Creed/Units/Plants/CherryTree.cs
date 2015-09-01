using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Units.Plants
{
    class CherryTree : Plant
    {
        public CherryTree(string id ) :
            base(id, 14,4,3)
        {
        }

        public override Product GetProduct()
        {
            if (IsAlive==true)
            {
                this.GrowTime = 3;
                 return new Food(this.Id + "Product", ProductType.Cherry, FoodType.Organic, this.ProductionQuantity, 2);
            }
            else
            {
                throw new InvalidOperationException("The cherry tree is dead.");
            }
           
        }
    }
}
