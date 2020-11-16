using Desafio.Model;
using Desafio.ViewModel;

namespace Desafio.Service
{
    /// <summary>
    /// Move Sonda Service Interface
    /// </summary>
    public interface IMoveSondaService
    {
        /// <summary>
        /// Move a list of sondas
        /// </summary>
        /// <param name="request">move sonda request</param>
        /// <returns>move sonda response</returns>
        MoveSondaResponse MoveSonda(MoveSondaRequest request);

        /// <summary>
        /// Move a Sonda
        /// </summary>
        /// <param name="sonda">sonda</param>
        /// <param name="moves">moves</param>
        /// <param name="limit">position limit</param>
        /// <returns>sonda position</returns>
        string MoveSonda(Sonda sonda, string moves = "", Position limit = null);
    }
}
