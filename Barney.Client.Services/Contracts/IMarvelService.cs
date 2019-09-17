using Barney.Client.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barney.Client.Services.Contracts
{
    interface IMarvelService
    {
        IEnumerable<MarvelCharacter> GetRandomCharacters();
    }
}
