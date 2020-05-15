using NameSorter.Domains;
using NameSorter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NameSorter.Services
{
    public class NameSorter : INameSorter
    {
        public IList<Name> Sort(IList<Name> names)
        {
            return names.OrderBy(x => x.LastName).ThenBy(x => x.GivenNames).ToList();
        }
    }
}
