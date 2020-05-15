using NameSorter.Domains;
using NameSorter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services
{
    public class NameConverter : INameConverter
    {
        public Name ConvertFromString(string name)
        {
            var nameParts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var givenNames = string.Join(' ', nameParts, 0, nameParts.Length - 1);
            return new Name(nameParts[nameParts.Length - 1], givenNames);
        }
    }
}
