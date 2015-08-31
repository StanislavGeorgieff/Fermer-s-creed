using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Units.Plants
{
    class TobaccoPlant:Plant
    {
        public TobaccoPlant(string id) 
            : base(id, 12, 10, 4)
        {

        }

        public override void Grow()
        {
            for (int i = 0; i < 2; i++)
            {
                 base.Grow();
            }
           
        }

        public override Product GetProduct()
        {
            if (HasGrown==true&&IsAlive==true)
            {
                 return new Product(Id+"Product",ProductType.Tobacco, this.ProductionQuantity);
            }
            else
            {
              throw new InvalidOperationException("The plant growing up or it's dead.");
            }
           
        }
    }
}
