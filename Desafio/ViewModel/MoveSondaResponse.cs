using System.Collections.Generic;

namespace Desafio.ViewModel
{
    /// <summary>
    /// Move Sonda Response
    /// </summary>
    public class MoveSondaResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MoveSondaResponse()
        {
            Positions = new List<string>();
        }

        /// <summary>
        /// Positions
        /// </summary>
        public IList<string> Positions { get; set; }
    }
}