using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    public class Chocolate:PRODUCT
    {

        //Public Properties
        public float Mass
        {
            get { return mass; }
        }


        //Private Properties

        private float mass;
        public Chocolate(string name,
                       long id,
                       decimal Cost,
                       int quantity,                      
                       float chocoMass) : base(name, id, Cost, quantity)
        {
            //Validate mass
            if (mass < 0)
            {
                throw new ArgumentException("Negative mass");
            }   
           mass = chocoMass;
        }
        public Chocolate(string name,
               long id,
               decimal Cost,               
               float chocoMass) : base(name, id, Cost)
        {
            //Validate mass
            if (mass < 0)
            {
                throw new ArgumentException("Negative mass");
            }
            mass = chocoMass;
        }
        public Chocolate(string fromFile) : base(fromFile)
        {
            char[] delimeters = { '|', ',' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);           
            mass = float.Parse(tokens[4]);
        }

        public override string ToFormattedString()
        {
            return base.ToFormattedString() + $" {mass,2:N2} Kg";
        }
        public override string ToString()
        {
            return base.ToString() + $" Ram: {mass} Kg ";
        }
        public override string ToFileString()
        {
            return base.ToFileString() + $"|{mass}";
        }
        public override int Sell(int quantitySold)
        {
            if (quantitySold % 2 != 0)
            {
                throw new ArgumentException("Choose Only Even Amount");
            }
            return base.Sell(quantitySold);
        }
    }
}
