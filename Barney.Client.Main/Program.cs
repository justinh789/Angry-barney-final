using Barney.Client.Services.Services;
using Barney.Client.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Barney.Client.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
                services.AddSingleton<IMarvelService, MarvelService>();

            var provider = services.BuildServiceProvider();


            var marvelCharacters = provider.GetService<IMarvelService>().GetRandomCharacter();

            foreach(var character in marvelCharacters)
            {
                Console.WriteLine("Name: " + character.Name + ". Age: " + character.Age +  ". Superpowers: " + character?.Superpowers?.ToString());
            }

            Console.WriteLine();
         }

        //static async Task MainAsync(string[] args)
        //{

        //}
    }
}
