using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace productForm
{
    public class DBAccess
    {
        public Product GetProduct(int ID)
        {

            try
            {
                Product product; //define an object called product under product class 
                // in C#, using XmlDocument -->xml data file
                XmlDocument xmldoc = new XmlDocument(); // define an object for xml document 

                xmldoc.Load("..//..//ProductsCategories.xml");

                string xpath = "/ProductCategories/Products[@ProductID='{0}']";// used to navigate through elements and attributes in an xml document 
                xpath = string.Format(xpath, ID);

                XmlNode userNode = xmldoc.SelectSingleNode(xpath);

                if(userNode != null)
                {
                    string quantityPerUnit = userNode.Attributes["QuantityPerUnit"].Value;
                    string productName = userNode.Attributes["ProductName"].Value;
                    decimal unitPrice = Decimal.Parse(userNode.Attributes["UnitPrice"].Value);
                    XmlNode childNode = userNode.ChildNodes[0];
                    string description = childNode.Attributes["Description"].Value;
                    product = new Product(quantityPerUnit, productName, unitPrice, description);
                    
                        
                }
                else
                {
                    //if product is not found let user know
                    product = new Product("", "", 0, "Product not found");
                }

                return product;
            }
            catch(Exception e )
            {
                System.Windows.MessageBox.Show(e.Message + "/n" + e.Source + "/n" + e.StackTrace);
            }
            
            return null;
        }

    }
}
