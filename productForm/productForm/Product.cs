using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productForm
{
    public class Product
    {
        string quantityPerUnit;
        string productName;       
        decimal unitPrice;
         string description;

        public string QuantityPerUnit
        {
            get { return quantityPerUnit; }
            set { quantityPerUnit = value; }
        }
        
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Product(string quantityPerUnit, string productName,decimal unitPrice, string description)
        {
            QuantityPerUnit = quantityPerUnit;
            ProductName = productName;
            UnitPrice = unitPrice;
            Description = description;


        }
    }
}
