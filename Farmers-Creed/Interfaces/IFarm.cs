using System.CodeDom;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Interfaces
{
  
    using System.Collections.Generic;
    using Units;
    using Units.Plants;

    public interface IFarm 
    {

        List<Plant> Plants { get; }

        List<Animal> Animals { get; }

        List<Product> Products { get; }

        void AddProduct(Product product);

        void Exploit(IProductProduceable productProducer);

        void Feed(Animal animal, IEdible edibleProduct, int productQuantity);

        void Water(Plant plant);

        void UpdateFarmState();
    }
}
