using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    public class PRODUCT
    {
        // Public properts of the Product Class
        public string ProductName                //short description of the produc
        {
            get
            {
                return productName;
            }
         
        }


        public long ID                           // Unique identifying number(SKU)
        {
            get
            {
                return iD;
            }

        }

        public int QuantityOnHand               // the count of the in-stock items of this product
        {
            get
            {
                return quantityOnHand;
            }

        }
        public decimal Cost                      // the cost of an invidual item in$
        

        {
             get
             {
               return cost;
             }
             set
             {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative");
                }
                cost = value;
             }
        }
        public decimal valueOfInventory// WHenever that depend on the other value, avoid to create an object but rather create a virtual properties
        {
            get
            {
                return QuantityOnHand*Cost;
            }
          
        }


        //Private Shadow Properties
        private string productName;
        private long iD;
        private int quantityOnHand;
        private decimal cost;
    
        

         //COnstructors

        public PRODUCT(string name, long ProductID, decimal productCost)
        {
            if (!validateProductName(name))
            {
                throw new ArgumentException("Bad Name");
            }
            if (!validateProductId(ProductID))
            {
                throw new ArgumentException("Bad Id");
            }
            productName = name;
            iD = ProductID;
            Cost = productCost;
            quantityOnHand = 0;
        }

        public PRODUCT(string name, long ProductID, decimal cost, int quantity)
        {
            {
                if (!validateProductName(name))
                {
                    throw new ArgumentException("Bad Name");
                }
                if (!validateProductId(ProductID))
                {
                    throw new ArgumentException("Bad Id");
                }
                if (!validateQuantityOnHand(quantity))
                {
                    throw new ArgumentException("quantity");
                }
                productName = name;
                iD = ProductID;
                Cost = cost;
               quantityOnHand = quantity ;
            }
        }
        public PRODUCT(string fromFile)
        {
            char[] delimeters = { '|', ',' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            productName = tokens[0];
            iD = long.Parse(tokens[1]);
            cost = decimal.Parse(tokens[3]);
            quantityOnHand = int.Parse(tokens[2]);
  
        }
        public virtual int Stock(int newQuantity)
        {
            if (newQuantity <= 0)
            {
              throw new ArgumentException("Invalid Restock Quantiy");
            }
            quantityOnHand += newQuantity;
            return QuantityOnHand;
        }
        public virtual int Sell(int quantitySold)
        {

            if (quantitySold <= 0)
            {
                throw new ArgumentException("Invalid Restock Quantiy");
            }
            if (quantitySold> quantityOnHand)
            {
                throw new ArgumentException("Insufficient Quantity");
            }
            quantityOnHand -= quantitySold;
            return QuantityOnHand;
        }
        public virtual string ToFormattedString()
        {
            string theString = "";
            theString += $"{productName,-30}";
            theString += $"{iD,12}";
            theString += $"{quantityOnHand,6}";
            theString += $"{cost,10:C2}";
            return theString;
        }
        public  virtual string ToFileString()
        {
            string theString = "";
            theString += $"{productName}|";
            theString += $"{iD}|";
            theString += $"{quantityOnHand}|";
            theString += $"{cost}";
            return theString;
        }

        public override string ToString()
        {
            return $" Product: Name:'{productName}' Id: {iD} Cost:{cost} Quantity: {quantityOnHand} in stock";
        }
        // Private (Helper method)
        private bool validateProductName(string name)
        {
            if (!((name != null) && (name.Length > 0)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool validateProductId(long productID)
        {
            if(!((productID >= 1000) && (productID <= 999999999)))
             {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateQuantityOnHand(int quantity)
        {
            if (!(quantity>=0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
