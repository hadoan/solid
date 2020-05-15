using NameSorter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services
{
    public class NameValidation : INameValidation
    {
        public bool IsValidName(string name)
        {
            var nameParts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // A name must have at least 1 given name and may have up to 3 given names
            return nameParts.Length >= 2 && nameParts.Length <= 4;
        }
    }
}
