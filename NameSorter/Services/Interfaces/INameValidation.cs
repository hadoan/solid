using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services.Interfaces
{
    public interface INameValidation
    {
        bool IsValidName(string name);
    }
}
