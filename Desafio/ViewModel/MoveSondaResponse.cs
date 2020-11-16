using System.Collections.Generic;

namespace Desafio.ViewModel
{
    public class MoveSondaResponse
    {
        public MoveSondaResponse()
        {
            Positions = new List<string>();
        }

        public IList<string> Positions { get; set; }
    }
}