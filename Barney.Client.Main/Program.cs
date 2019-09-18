using Barney.Client.Services.Services;
using Barney.Client.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Barney.Client.Main
{
    class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
                services.AddSingleton<IMarvelService, MarvelService>();

            var provider = services.BuildServiceProvider();


            DiscordSubscriptions.MainAsync(args, provider).ConfigureAwait(false).GetAwaiter().GetResult();

        }

       
    }
}
