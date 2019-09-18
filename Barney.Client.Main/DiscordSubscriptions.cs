using Barney.Client.Core;
using Barney.Client.Services.Contracts;
using DSharpPlus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using Barney.Client.Main.Commands;

namespace Barney.Client.Main
{
    public static class DiscordSubscriptions
    {
        private static DiscordClient _discordClient;
        private static CommandsNextModule _commands;

        public static async Task MainAsync(string[] args, ServiceProvider serviceProvider)
        {
            _discordClient = new DiscordClient(new DiscordConfiguration
            {
                Token = SensitiveData.BarneyToken,
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });



            //Say Hi
            _discordClient.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().Contains("hey barney"))
                    await e.Message.RespondAsync("Barney Here");
            };

            //Tell me something cool.
            _discordClient.MessageCreated += async e => {
                if (e.Message.Content.ToLower().Contains("something cool"))
                {
                    //Go get Random marvel quotes.
                    var marvelCharacter = serviceProvider.GetService<IMarvelService>().GetRandomCharacters();
                    foreach(var character in marvelCharacter)
                    {
                        await e.Message.RespondAsync(character.Name);
                    }
                }
            };

            _commands = _discordClient.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = ";;"
            });

            _commands.RegisterCommands<MyCommands>();
            

            await _discordClient.ConnectAsync();
            await Task.Delay(-1);

        }

    }
}
