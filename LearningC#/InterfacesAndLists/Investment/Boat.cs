using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndLists.Investment
{
    internal class Boat : IInvestment
    {
        private int? length;

        // Constructor
        public Boat(int inLength, int inMeterPrice, Conditions condition, string inDescription, int inRegYear) 
        { 
            Length = inLength;
            MeterPrice = inMeterPrice; 
            Condition = condition; 
            Description = inDescription; 
            RegYear = inRegYear; 
        } 
        /* Properties */ 
        public int? Length 
        {
            get { return length; }
            set { 
                if (value <= 0)
                {
                    length = null;
                }
                else
                {
                    length = value;
                }

            }
        } 
        public int MeterPrice { get; set; } 
        public Conditions Condition { get; set; } 
        public string Description { get; set; } 
        public int RegYear { get; set; } 
        /* Methods */ 
        public int? PriceCalculate() 
        { 
            int? foundPrice = Length * MeterPrice; 
            return foundPrice; 
        } 
        public string InvestSummary() 
        { 
            string summ = "Boat: " + Description + Environment.NewLine + "Length " + Length; 
            summ += Environment.NewLine + "Price: " + PriceCalculate(); 
            return summ; 
        }

        public override string? ToString()
        {
            string str = $"Boat: {Description}" +
                         $"Length: {Length}" +
                         $"Price: {PriceCalculate()}" +
                         $" {Description}";
            return str;
        }
    }
}
