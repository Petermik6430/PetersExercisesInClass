using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndLists.Investment
{
    class Painting : IInvestment
    {


        public Painting(string inPainter, string inTitle, int inYear, int price, Conditions condition)
        {
            Painter = inPainter;
            Title = inTitle;
            Year = inYear;
            Price = price;
            Condition = condition;
        }

        public string Painter { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Conditions Condition { get; set; }
        public int Price { get; set; }

        public string InvestSummary()
        {
            string summ = "Painting: " + Title + " Painter: " + Painter + Environment.NewLine + " Year: " + Year + " Condition " + Condition ;
            summ += Environment.NewLine + " Price: " + PriceCalculate();

            return summ;
        }

        public int? PriceCalculate()
        {
            int foubdPrice = Price * Year;
            return foubdPrice;
        }

        public override string? ToString()
        {
            string str = $"Painting: {Title}" +
                         $"Painter: {Painter}" +
                         $"Year: {Year}" +
                         $"Price: {PriceCalculate()}" +
                         $" {Condition}";
            return str;
        }
    }
}
