using Barney.Client.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barney.Client.Services.Contracts
{
    public interface IMarvelService : IDisposable
    {
        IEnumerable<MarvelCharacter> GetRandomCharacter();
    }
}
