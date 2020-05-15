using NameSorter.Domains;
using NameSorter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorter.Services
{
    public class NamesStorage : INamesStorage
    {
        private readonly INameValidation _nameValidation;
        private readonly INameConverter _nameConverter;
        private readonly INameSorter _nameSorter;

        private IList<Name> _names;

        public NamesStorage(INameValidation nameValidation, INameConverter nameConverter, INameSorter nameSorter)
        {
            _nameValidation = nameValidation;
            _nameConverter = nameConverter;
            _names = new List<Name>();
            _nameSorter = nameSorter;
        }

        public void AddName(string name)
        {
            if (_nameValidation.IsValidName(name))
            {
                var nameObject = _nameConverter.ConvertFromString(name);
                _names.Add(nameObject);
                Console.WriteLine($"Name {name} is valid.");
            }
            else
            {
                Console.WriteLine($"Error: Name {name} is not valid, remove from list!");
            }
        }

        public void SortNames()
        {
            _names = _nameSorter.Sort(_names);
        }


        public IList<string> ToNamesStringList()
        {
            return _names.Select(x => $"{x.GivenNames} {x.LastName}").ToList();
        }
    }
}
