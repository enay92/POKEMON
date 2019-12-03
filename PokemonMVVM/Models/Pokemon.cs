using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PokemonMVVM.Models
{
    public class PokemonAPIResult
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Pokemon> Results { get; set; }
    }
    public class Pokemon
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string GetID
        {
            get
            {
                var regex = new Regex(@"[^/]+(?=/$|$)");
                Match matchs = regex.Match(Url);
                return "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + matchs.Value + ".png";
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
