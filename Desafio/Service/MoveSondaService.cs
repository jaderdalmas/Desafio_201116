using Desafio.Model;
using Desafio.ViewModel;
using System.Linq;

namespace Desafio.Service
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class MoveSondaService : IMoveSondaService
    {
        public MoveSondaService() { }

        public MoveSondaResponse MoveSonda(MoveSondaRequest request)
        {
            if (request.Sondas?.Any() != true || request.Moves?.Any() != true || request.Sondas?.Count() != request.Moves?.Count())
                return null;

            var result = new MoveSondaResponse();
            for (int i = 0; i < request.Sondas.Count(); i++)
            {
                result.Positions.Add(MoveSonda(request.Sondas.ElementAt(i), request.Moves.ElementAt(i), request.Limit));
            }

            return result;
        }

        public string MoveSonda(Sonda sonda, string moves = "", Position limit = null)
        {
            if (sonda == null)
                return string.Empty;
            if (string.IsNullOrWhiteSpace(moves))
                return sonda.ToString();

            foreach (var move in moves)
                sonda.Move(move);

            return sonda.ToString(limit);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
