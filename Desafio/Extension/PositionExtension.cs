using Desafio.Model;

namespace Desafio.Extension
{
    /// <summary>
    /// Position Extension
    /// </summary>
    public static class PositionExtension
    {
        /// <summary>
        /// Validate Out of Limit
        /// </summary>
        /// <param name="position">Position</param>
        /// <param name="limit">Limit</param>
        /// <returns>true if out of limit</returns>
        public static bool OutOfLimit(this Position position, Position limit)
        {
            if (limit == null) 
                return false;

            return position.X > limit.X || position.Y > limit.Y;
        }
    }
}
