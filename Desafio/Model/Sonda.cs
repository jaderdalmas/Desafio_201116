using Desafio.Extension;

namespace Desafio.Model
{
    /// <summary>
    /// Sonda
    /// </summary>
    public class Sonda
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="front">Front</param>
        public Sonda(int x = 0, int y = 0, EFront front = EFront.N)
        {
            Position = new Position(x, y);
            Front = front;
        }

        /// <summary>
        /// Position
        /// </summary>
        public Position Position { get; private set; }

        /// <summary>
        /// Front
        /// </summary>
        public EFront Front { get; private set; }

        /// <summary>
        /// Move
        /// </summary>
        /// <param name="move">movement char</param>
        public void Move(char move)
        {
            if (move == 'M')
                Position.Move(Front);
            else
                Front = Front.Move(move);
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>position if not invalid</returns>
        public override string ToString()
        {
            if (Position.IsInvalid())
                return "Invalid";

            return $"{Position} {Front}";
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <param name="limit">position limit</param>
        /// <returns>position if not invalid</returns>
        public string ToString(Position limit)
        {
            if (Position.IsInvalid(limit))
                return "Invalid";

            return $"{Position} {Front}";
        }
    }
}
