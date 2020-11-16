using Desafio.Model;
using System.Collections.Generic;

namespace Desafio.ViewModel
{
    /// <summary>
    /// Move Sonda Request
    /// </summary>
    public class MoveSondaRequest
    {
        /// <summary>
        /// Limit
        /// </summary>
        public Position Limit { get; set; }

        /// <summary>
        /// Sondas
        /// </summary>
        public IEnumerable<Sonda> Sondas { get; set; }

        /// <summary>
        /// Moves
        /// </summary>
        public IEnumerable<string> Moves { get; set; }
    }
}