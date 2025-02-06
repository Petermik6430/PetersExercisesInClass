using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaToC_.JavaToC_Challenge.Model;

namespace JavaToC_
{
    internal class Employee : PersonI
    {

        public Employee(string? name) 
        { 
            Name = name;
            FaverouriteWord = new List<string?>();
        
        }
        public string? Name { get; set; }

        public List<string?>? FaverouriteWord { get; set; }

        public void AddFavouriteWord(string newWord)
        {
            FaverouriteWord.Add(newWord);
            
        }

        public override string? ToString()
        {
            string? str = $"{Name} \n {FaverouriteWord}";
            return str;
        }
    }

    
}
