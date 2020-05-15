using NameSorter.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services.Interfaces
{
    public interface INameConverter
    {
        Name ConvertFromString(string name);
    }
}
