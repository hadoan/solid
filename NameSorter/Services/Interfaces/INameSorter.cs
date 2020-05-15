using NameSorter.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services.Interfaces
{
    public interface INameSorter
    {
        IList<Name> Sort(IList<Name> names);
    }
}
