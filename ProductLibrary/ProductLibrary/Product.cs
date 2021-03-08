using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class Product
    {
        private int ID;
        private string Name;
        private int Quantity;
        private float UnitPrice;

        //constructor
        public Product()
        {
        }

        public Product(int ID, string Name, int Quantity, float UnitPrice)
        {
            this.ID = ID;
            this.Name = Name;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
        }

        //getters, setters
        public int ProductID
        {
            get => ID;
            set => ID = value;
        }

        public string ProductName
        {
            get => Name;
            set => Name = value;
        }

        public int ProductQuantity
        {
            get => Quantity;
            set => Quantity = value;
        }

        public float Price
        {
            get => UnitPrice;
            set => UnitPrice = value;
        }

        public float GetTotal
        {
            get => UnitPrice * Quantity;
        }
    }
}
