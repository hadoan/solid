using NameSorter.Services.Interfaces;
using System;


namespace NameSorter.Services
{
    public class FileHandlerService : IFileHandlerService
    {

        private string inputFileName;
        private string outputFileName;
        private readonly INamesStorage _namesStorage;
        public FileHandlerService(INamesStorage namesStorage)
        {
            this._namesStorage = namesStorage;
        }

        public void Handle()
        {
            try
            {
                if (!System.IO.File.Exists(inputFileName))
                {
                    Console.WriteLine($"{inputFileName} couldn't be found at {AppContext.BaseDirectory}.");
                    return;
                }
                Console.WriteLine($"Processing file {inputFileName}.");
                var lines = System.IO.File.ReadAllLines(inputFileName);
                int i = 1;
                foreach (var lineContent in lines)
                {
                    Console.WriteLine($"{i} processing name for {lineContent}.");
                    _namesStorage.AddName(lineContent);
                    i++;
                }

                Console.WriteLine($"Sorting names.");
                _namesStorage.SortNames();

                System.IO.File.WriteAllLines(outputFileName, _namesStorage.ToNamesStringList());

                Console.WriteLine($"Sorted sucessfully and wrote to file {outputFileName}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                //Help();
                Console.WriteLine($"Error Detail: {ex}");
            }
        }

        public void SetInputFileName(string fileName)
        {
            this.inputFileName = fileName;
        }

        public void SetOutputFileName(string fileName)
        {
            this.outputFileName = fileName;
        }
    }
}