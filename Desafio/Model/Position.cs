using Desafio.Extension;

namespace Desafio.Model
{
    /// <summary>
    /// Position
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public Position(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Y
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// Move based on front
        /// </summary>
        /// <param name="front">front</param>
        public void Move(EFront front)
        {
            switch (front)
            {
                case EFront.N:
                    X++;
                    break;
                case EFront.W:
                    Y--;
                    break;
                case EFront.S:
                    X--;
                    break;
                case EFront.E:
                    Y++;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Validate object
        /// </summary>
        /// <param name="limit">position limit</param>
        /// <returns>true on invalid</returns>
        public bool IsInvalid(Position limit = null) => X < 0 || Y < 0 || this.OutOfLimit(limit);

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>position if not invalid</returns>
        public override string ToString()
        {
            if (IsInvalid())
                return "Invalid";

            return $"{X} {Y}";
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <param name="limit">position limit</param>
        /// <returns>position if not invalid</returns>
        public string ToString(Position limit)
        {
            if (IsInvalid(limit))
                return "Invalid";

            return $"{X} {Y}";
        }
    }
}
