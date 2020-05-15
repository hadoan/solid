using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services.Interfaces
{
    public interface INamesStorage
    {
        void AddName(string name);

        void SortNames();

        IList<string> ToNamesStringList();
    }
}
