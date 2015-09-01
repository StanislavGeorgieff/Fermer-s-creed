using System.Linq;
using System.Text;
using FarmersCreed.Units.Plants;
using FarmersCreed.Units.Products;

namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Farm : GameObject, IFarm
    {
        public Farm(string id)
            : base(id)
        {
            this.Plants = new List<Plant>();
            this.Animals = new List<Animal>();
            this.Products = new List<Product>();
        }

        public List<Plant> Plants { get; set; }

        public List<Animal> Animals { get; set; }

        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            Product ExistingProduct = this.Products.FirstOrDefault(prod => prod.Id == product.Id);
            if (ExistingProduct != null)
            {
                ExistingProduct.Quantity += product.Quantity;
            }
            else
            {
                this.Products.Add(product);
            }
        }

        public void Exploit(IProductProduceable productProducer)
        {
            if (productProducer != null)
            {
                this.AddProduct(productProducer.GetProduct());
            }
            else
            {
                throw new InvalidOperationException("The producer can not be null!");
            }


        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {

            animal.Eat(edibleProduct, productQuantity);
            edibleProduct.Quantity -= productQuantity;

        }

        public void Water(Plant plant)
        {
            plant.Water();
        }

        public void UpdateFarmState()
        {
            foreach (var plant in Plants)
            {
                if (plant.IsAlive)
                {

                    if (plant.HasGrown)
                    {
                        plant.Wither();
                    }
                    else
                    {
                        plant.Grow();
                    }
                }
            }

            foreach (var animal in Animals.Where(animal => animal.IsAlive))
            {
                animal.Starve();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var aliveAnimals = this.Animals.Where(animal => animal.IsAlive == true);
            sb.AppendFormat("--{0} {1}", this.GetType().Name, this.Id).AppendLine();
            foreach (var animal in aliveAnimals)
            {
                sb.AppendLine(animal.ToString());
            }
            var aliveplant = this.Plants.Where(plant => plant.IsAlive == true);
            foreach (var plant in aliveplant)
            {
                sb.AppendLine(plant.ToString());
            }
            foreach (var product in this.Products)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString();

        }
    }

}
