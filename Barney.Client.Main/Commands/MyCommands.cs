using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;


/// <summary>
/// ref: https://dsharpplus.emzi0767.com/articles/commandsnext.html
/// Commands are basically methods with specific signatures. All commands must be public instance methods, that return a Task. They also need to take CommandContext as first argument.
//Commands work by invoking the method which is tied to the command when any users sends a message that consists of a prefix, command name, and its arguments, for example: !hi
//Commands are marked with a special attribute.When you register commands, the library looks for methods with that attribute and marks these methods as commands.
/// </summary>
namespace Barney.Client.Main.Commands
{
    public class MyCommands
    {
        [Command("hi")]
        public async Task Hi(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 Hi, {ctx.User.Mention}!");
        }
    }
}
