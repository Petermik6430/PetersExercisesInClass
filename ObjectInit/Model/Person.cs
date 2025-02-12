﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectInit.Model
{
    public class Person
    {

        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }

        
        //public Person( DateTime birthDate, string? inName) : this(inName)
        //{
        //    BirthDate = birthDate;
        //}

        //public Person(string? inName = null)
        //{
        //    Name = inName;
        //}

      

        public override string? ToString()
        {
            string str = $"Name: {Name}, BirthDate: {BirthDate} ";
            return str;
        }
    }
}
