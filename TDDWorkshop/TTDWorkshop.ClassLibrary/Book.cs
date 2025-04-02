using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTDWorkshop.ClassLibrary
{
    public class Book
    {
        private int _stock;
        private double _price;

        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        public double Price {

            get { return _price; }

            set { 
                if (value < 0)
                {
                    value = 1;
                }
                _price = value;
            }
        
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _stock = value;
            }
        }
        public Book(string isbn, string title, string description)
        {
            ISBN = isbn;
            Title = title;
            Description = description;
        }

        public Book(string isbn, string title, string description, double price, int stock) : this(isbn, title, description)
        {
        
            Price = price;
            Stock = stock;
        }

        public override string? ToString()
        {
            string str = $"Title: {Title}, Description: {Description}, ISBN: {ISBN}, Price: {Price}, Stock: {Stock}";
            return str;
        }
    }
}
