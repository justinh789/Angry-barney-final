using Barney.Client.Core.Models;
using Barney.Client.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barney.Client.Services.Services
{
    public class MarvelService : IMarvelService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MarvelCharacter> GetRandomCharacter()
        {
            List<MarvelCharacter> mock = new List<MarvelCharacter>();

            mock.Add(new MarvelCharacter() { Age = "26", Name = "Spider Man" });

            return mock;
        }
    }
}
