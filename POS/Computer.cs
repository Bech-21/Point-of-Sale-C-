using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductInventory
{
    class Computer : PRODUCT
    {
        //Public Properties
        public int RamSize
        {
            get { return ramSize; }
        }
        public float CpuSpeed
        {
            get { return cpuSpeed; }
        }

        //Private Properties
        private int ramSize;
        private float cpuSpeed;


        //Constructor

        public Computer(string name,
                        long id,
                        decimal Cost,
                        int quantity,
                        int ram,
                        float speed) : base(name, id, Cost, quantity)
        {
            //Validate the ram and speed
            if (ram < 0)
            {
                throw new ArgumentException("Negative Ram size");
            }
            if (speed < 0)
            {
                throw new ArgumentException("Negative cpu speed");
            }
            ramSize = ram;
            cpuSpeed = speed;

        }
        public Computer(string name,
                   long id,
                   decimal Cost,
                 
                   int ram,
                   float speed) : base(name, id, Cost)
        {
            //Validate the ram and speed
            if (ram < 0)
            {
                throw new ArgumentException("Negative Ram size");
            }
            if (speed < 0)
            {
                throw new ArgumentException("Negative cpu speed");
            }
            ramSize = ram;
            cpuSpeed = speed;

        }
        public Computer(string fromFile) : base(fromFile)
        {
            char[] delimeters = { '|', ',' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            ramSize= int.Parse(tokens[4]);
            cpuSpeed= float.Parse(tokens[5]);
        }
        public override string ToFormattedString() 
        {
            return base.ToFormattedString() + $" {ramSize,3} GB {cpuSpeed,7:N2} MHz";
        }
        public override string ToString()
        {
            return base.ToString()+$" Ram: {ramSize} GB Speed: {cpuSpeed} MHz";
        }
        public override string   ToFileString()
        {
            return base.ToFileString() + $"|{ramSize}|{cpuSpeed}";
        }
    }
}