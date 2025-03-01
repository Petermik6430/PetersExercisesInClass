using System;
using System.Collections.Generic;
using InterfacesAndLists.Investment;

namespace InterfacesAndLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of investments
            
            // Create a house and a boat
            //List<House> houses = new List<House>();
            //List<Boat> boats = new List<Boat>();

            List<IInvestment> investments = new List<IInvestment>();

            House house = new House("ABC", 200, 200000, "Good", "Nice house");
            House house1 = new House("CBA", 100, 400000, "Good", "Nice house");
            Boat boat = new Boat(10, 10000, "Good", "Fast track boat", 2010);

            // Add the house and the boat to the list

            investments.Add(house);
            investments.Add(house1);

            investments.Add(boat);


            // Loop through the list and print the investment summary
            //foreach (House livingHouse in houses)
            //{
            //    Console.WriteLine("House: " + livingHouse.Address);
            //    Console.WriteLine("Area = " + livingHouse.SquareMeters);
            //    Console.WriteLine("Price: " + livingHouse.SquareMeterPrice);
            //}

            //foreach(Boat personboat in boats)
            //{
            //    Console.WriteLine("Boat: " + personboat.Description);
            //    Console.WriteLine("Length: " + personboat.Length);
            //    Console.WriteLine("Price: " + personboat.PriceCalculate());
            //}

            foreach (IInvestment investment in investments)
            {
                if(investment is House)
                {
                    House houseInvestment = (House)investment;
                    Console.WriteLine("Hosue: " + houseInvestment.Address);
                    Console.WriteLine("Area: " + houseInvestment.SquareMeters);
                    Console.WriteLine("Price: " + houseInvestment.SquareMeterPrice + "\n");
                }
                else if(investment is Boat)
                {
                    Boat boatInvestment = (Boat)investment;
                    Console.WriteLine("Boat: " + boatInvestment.Description);
                    Console.WriteLine("Length: " + boatInvestment.Length);
                    Console.WriteLine("Price: " + boatInvestment.PriceCalculate() + "\n");
                }
               
            }


        }
    }
}  