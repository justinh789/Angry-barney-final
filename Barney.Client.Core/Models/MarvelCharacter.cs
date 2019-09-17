using System;
using System.Collections.Generic;
using System.Text;

namespace Barney.Client.Core.Models
{
    public class MarvelCharacter
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public List<String> Superpowers { get; set; }
    }
}
