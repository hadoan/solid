using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Services.Interfaces
{
    public interface IFileHandlerService 
    {
        void Handle();

        void SetInputFileName(string fileName);

        void SetOutputFileName(string fileName);
    }
}
