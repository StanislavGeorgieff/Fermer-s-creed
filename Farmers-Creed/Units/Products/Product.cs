namespace FarmersCreed.Units.Products
{
    using System;
    using System.Collections.Generic;

    public class Product : GameObject, IProduct
    {
        private int quantity;
        private ProductType productType;

        public Product(string id, ProductType productType, int quantity)
            : base(id)
        {
            this.Quantity = quantity;
            this.ProductType = productType;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product quantity cannot be negative!");
                }
                this.quantity = value;
            }
        }

        public ProductType ProductType
        {
            get { return this.productType; }
            set { this.productType = value; }
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            string name = this.Id;
            int quantity = this.Quantity;
            string productType = this.ProductType.ToString();
            //--Product TutunProduct, Quantity: 10, Product Type: Tobacco

            string result= String.Format("--{0} {1}, Quantity: {2}, Product Type: {3}", type, name, quantity, productType);
            return result;
        }
    }
}
