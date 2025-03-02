using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Employee : IPerson
    {
        public string EmployeeName { get; set; }
        public List<string> FavoriteWords { get; set; }
        public Employee(string employeeName)
        {
            EmployeeName = employeeName;
            FavoriteWords = new List<string>();
        }
        public void AddFavoriteWord(string newWord)
        {
            FavoriteWords.Add(newWord);
        }

        public override string ToString()
        {
            string str = string.Format($"Employee Name: {EmployeeName}");
            return str;
        }
    }
}
