using Desafio.Model;
using System.Collections.Generic;

namespace Desafio.ViewModel
{
    public class MoveSondaRequest
    {
        public Position Limit { get; set; }
        public IEnumerable<Sonda> Sondas { get; set; }
        public IEnumerable<string> Moves { get; set; }
    }
}