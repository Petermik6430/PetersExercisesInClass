using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndLists.Investment
{
    internal class Boat : IInvestment
    {

        // Constructor
        public Boat(int inLength, int inMeterPrice, string inCondition, string inDescription, int inRegYear) 
        { 
            Length = inLength;
            MeterPrice = inMeterPrice; 
            Condition = inCondition; 
            Description = inDescription; 
            RegYear = inRegYear; 
        } 
        /* Properties */ 
        public int Length { get; set; } 
        public int MeterPrice { get; set; } 
        public string Condition { get; set; } 
        public string Description { get; set; } 
        public int RegYear { get; set; } 
        /* Methods */ 
        public int PriceCalculate() 
        { 
            int foundPrice = Length * MeterPrice; 
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
