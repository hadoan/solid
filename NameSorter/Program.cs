using System;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using NameSorter.Services;
using NameSorter.Services.Interfaces;

namespace NameSorter
{
    class Program
    {
        private static ServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            //setup our DI
            SetupContainer();

            if (args.Length != 2)
            {
                Console.WriteLine("Please indicate un-sorted file name in argument, eg: NameSorter.exe unsorted-names-list.txt");
            }
            else
            {
                var inputFile = args[0];
                var outputFile = args[1];

                var fileInputHandler = serviceProvider.GetService<IFileHandlerService>();
                fileInputHandler.SetInputFileName(inputFile);
                fileInputHandler.SetOutputFileName(outputFile);
                fileInputHandler.Handle();
            }
        }



        private static void SetupContainer()
        {
            serviceProvider = new ServiceCollection()
                     .AddSingleton<INameConverter, NameConverter>()
                     .AddSingleton<INamesStorage, NamesStorage>()
                     .AddSingleton<INameValidation, NameValidation>()
                     .AddSingleton<IFileHandlerService, FileHandlerService>()
                     .AddSingleton<INameSorter, NameSorter.Services.NameSorter>()
                     .BuildServiceProvider();

        }
    }
}
