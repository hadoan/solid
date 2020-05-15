using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Domains
{
    public class Name
    {
        public Name(string lastName, string givenNames)
        {
            LastName = lastName;
            GivenNames = givenNames;
        }

        public string LastName { get; set; }

        public string GivenNames { get; set; }
    }
}
